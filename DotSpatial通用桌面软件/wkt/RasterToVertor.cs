using DotSpatial.Data;
using DotSpatial.Symbology;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wkt
{
    public delegate void RasterToVertorDelegate(string input, string outputFileName);
    public partial class RasterToVertor : Form
    {
        public RasterToVertor(List<string> layers)
        {
            InitializeComponent();
            foreach (string name in layers)
            {
                cbRTVInput.Items.Add(name);
            }
        }


        //输出文件
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            sfdVector.Filter = "Shape File(*.shp)|*.shp|All File(*.*)|*.*";
            sfdVector.FileName = "";
            sfdVector.AddExtension = true;
            sfdVector.FilterIndex = 1;
            sfdVector.RestoreDirectory = true;
            DialogResult dialogResult = sfdVector.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (sfdVector.FileName == "" || sfdVector.FileName == null)
                {
                    MessageBox.Show("请输入文件名！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbVectorPath.Text = sfdVector.FileName;
                }
            }

        }

        public event RasterToVertorDelegate RTVEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectName = cbRTVInput.SelectedItem.ToString();
            string VectorPath = tbVectorPath.Text;
            RTVEvent(selectName, VectorPath);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
