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
    public delegate void InterruptLineWL(string selectLayer, string sourceLayer, string path);
    public partial class InterruptLineWithLine : Form
    {
        public InterruptLineWithLine(List<string> layername)
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
            saveFileDialog.Filter = "shp files(*.shp)|*.shp";
            saveFileDialog.FileName = "";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //System.IO.File.WriteAllLines(saveFileDialog1.FileName, str);   //写到txt文本中   
                tbPath.Text = saveFileDialog.FileName;
                // MessageBox.Show("该图层对应的WKT文本保存成功");
            }
        }

        public event InterruptLineWL InterruptLineWLEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectname = cbSelectLayer.SelectedItem.ToString();
            string targetname = cbTargetLayer.SelectedItem.ToString();
            string path = tbPath.Text;
            InterruptLineWLEvent(selectname, targetname, path);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
