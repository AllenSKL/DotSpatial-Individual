using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wkt
{
    public class DBHelper
    {
        public DataTable DBQuery(string sqlCon,string sqlCom)
        {
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sqlCom, con))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(com);                 
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public int DBUpdate(string sqlCon, string sqlCom)
        {
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlCom, con))
                {
                    int a = cmd.ExecuteNonQuery();
                    return a;
                }
            }
        }

        public int DBScalar(string sqlCon, string sqlCom)
        {
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlCom, con))
                {
                    int s;
                    s = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    return s;
                }
            }
        }
    }
}
