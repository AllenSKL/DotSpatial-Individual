using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace wkt
{
    public struct Field
    {
        public string Name;
        public string Type;
    }

    public partial class LinkDB : Form
    {
        public delegate void pullData(List<string> tableName, List<DataTable> table);
        public LinkDB()
        {
            InitializeComponent();
        }

        public event pullData pullDTEvent;

        private void btnOK_Click(object sender, EventArgs e)
        {
            string server = tbServer.Text.ToString();
            string user = tbUser.Text.ToString();
            string pwd = tbPwd.Text.ToString();
            string db = tbDB.Text.ToString();

            #region
            //todo:获取table名传到mainForm中的“数据库”treeview中。
            //获取数据库Table表名,Table不能写死。
            string sqlCon = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", server, db, user, pwd);

            List<string> TableName = new List<string>();
            List<DataTable> table = new List<DataTable>();
            string[] restrictionValueTableName = new string[4];
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();

                restrictionValueTableName[0] = db;
                //restrictionValueTableName[1] = null;
                //restrictionValueTableName[2] = null;
                //restrictionValueTableName[3] = null;
                using (DataTable da = con.GetSchema(SqlClientMetaDataCollectionNames.Tables, restrictionValueTableName))
                {
                    foreach (DataRow dr in da.Rows)
                    {
                        string DBTableName = dr["table_name"].ToString();
                        string sqlCom = "select * from ";       
                        DataTable dt = new DataTable();
                        sqlCom += DBTableName;
                        TableName.Add(DBTableName);
                        using (SqlCommand com = new SqlCommand(sqlCom, con))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(com);
                            dt.TableName = DBTableName;//设置读取的表的名称。
                            sda.Fill(dt);
                            table.Add(dt);
                        }
                    }
                }
                con.Dispose();
            }
            pullDTEvent(TableName, table);

            #region 获取数据库Table表的字段名
            //List<Field> Field = new List<Field>();
            //string tableName = "australia";
            //string[] restrictionValues = new string[4];
            //restrictionValues[0] = null;
            //restrictionValues[1] = null;
            //restrictionValues[2] = tableName;
            //restrictionValues[3] = null;
            //using (DataTable ds = con.GetSchema(SqlClientMetaDataCollectionNames.Columns, restrictionValues))
            //{
            //    foreach (DataRow dr in ds.Rows)
            //    {
            //        Field fields;
            //        fields.Name = dr["column_name"].ToString();
            //        fields.Type = dr["data_type"].ToString();
            //        Field.Add(fields);
            //    }
            //}
            #endregion
            #endregion


            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //返回填写的值到mainForm
        public string[] information
        {
            get
            {
                string[] info = new string[4] { "", "", "", "" };
                info[0] = tbServer.Text.ToString();
                info[0] = tbUser.Text.ToString();
                info[0] = tbPwd.Text.ToString();
                info[0] = tbDB.Text.ToString();
                return info;
            }
        }


    }
}
