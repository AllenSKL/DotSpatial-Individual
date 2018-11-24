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
    public delegate void layernamedelegate(string selectName, double distance, string resultPath);
    public partial class Buffer : Form
    {
        public Buffer(List<string> layername)
        {
            InitializeComponent();
            foreach (string name in layername)
            {
                this.cbSelectLayer.Items.Add(name);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialogBuffer.Filter = "shp files(*.shp)|*.shp";
            saveFileDialogBuffer.FileName = "";
            saveFileDialogBuffer.AddExtension = true;
            saveFileDialogBuffer.FilterIndex = 1;
            saveFileDialogBuffer.RestoreDirectory = true;
            DialogResult result = saveFileDialogBuffer.ShowDialog();
            if (result == DialogResult.OK)
            {
                //System.IO.File.WriteAllLines(saveFileDialog1.FileName, str);   //写到txt文本中   
                tbResultPath.Text = saveFileDialogBuffer.FileName;
                // MessageBox.Show("该图层对应的WKT文本保存成功");

            }
        }
        //执行缓冲区分析 
        public event layernamedelegate bufferEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectName = cbSelectLayer.SelectedItem.ToString();
            double distance = Convert.ToDouble(tbDistance.Text);
            string resultPath = tbResultPath.Text;
            bufferEvent(selectName, distance, resultPath);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
