using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wkt
{
    public partial class WKTViwer : Form
    {
        public WKTViwer(string wktStr)
        {

            InitializeComponent();
            rtbWKT.Text = wktStr;
        }

        private void exportAsTxt_Click(object sender, EventArgs e)
        {
            List<string> wktList = new List<string>();
            wktList.Add(rtbWKT.Text);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
            saveFileDialog.FileName = "";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, wktList);   //写到txt文本中             
                MessageBox.Show("该图层对应的WKT文本保存成功");
            }

        }
    }
}
