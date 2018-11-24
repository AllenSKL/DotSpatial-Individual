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
    public delegate void xiangjiaodelegate(string selectedName, string targetName, string path);
    public partial class Union : Form
    {
        public Union(List<string> layername)
        {
            InitializeComponent();
            foreach (string name in layername)
            {
                this.cbSelectLayer.Items.Add(name);
                this.cbTargetLayer.Items.Add(name);
            }

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "shp files(*.shp)|*.shp";
            saveFileDialog1.FileName = tbResultPath.Text+".shp";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //System.IO.File.WriteAllLines(saveFileDialog1.FileName, str);   //写到txt文本中   
                tbResultPath.Text = saveFileDialog1.FileName;
                // MessageBox.Show("该图层对应的WKT文本保存成功");

            }
        }

        public event xiangjiaodelegate unionEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectName = cbSelectLayer.SelectedItem.ToString();
            string targetname = cbTargetLayer.SelectedItem.ToString();
            string SC = tbResultPath.Text;
            unionEvent(selectName, targetname, SC);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
