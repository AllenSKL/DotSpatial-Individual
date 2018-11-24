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
    public partial class ReverseIntersect : Form
    {
        public delegate void ReverseIntersectionDelegate(string inlayer, string updateLayer, string path);
        public ReverseIntersect(List<string> layerName)
        {
            InitializeComponent();
            foreach (string name in layerName)
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

        public event ReverseIntersectionDelegate ReverseIntersectEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectname = cbSelectLayer.SelectedItem.ToString();
            string targetname = cbTargetLayer.SelectedItem.ToString();
            string path = tbPath.Text;
            ReverseIntersectEvent(selectname, targetname, path);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
