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
    public delegate void InterruptLineWP(string lineLayer, string pointLayer, string path);
    public partial class InterruptLineWithPoint : Form
    {
        public InterruptLineWithPoint(List<string> layername)
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
                tbPath.Text = saveFileDialog.FileName;
            }

        }

        public event InterruptLineWP InterruptLineWPEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string lineName = cbSelectLayer.SelectedItem.ToString();
            string pointName = cbTargetLayer.SelectedItem.ToString();
            string path = tbPath.Text;
            InterruptLineWPEvent(lineName, pointName, path);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
