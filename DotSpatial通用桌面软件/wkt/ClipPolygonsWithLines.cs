using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Data;

namespace wkt
{
    public delegate void ClipPolygonWithLineDelegate(string linelayer, string PolyLayer, string RPolyLayer);
    public partial class ClipPolygonsWithLines : Form
    {
        public ClipPolygonsWithLines(List<string> layerName)
        {
            InitializeComponent();
            foreach (string name in layerName)
            {
                this.cbLineLayer.Items.Add(name);
                this.cbPolyLayer.Items.Add(name);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event ClipPolygonWithLineDelegate ClipPolygonWithLineEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string LineName = cbLineLayer.SelectedItem.ToString();
            string PolygonName = cbPolyLayer.SelectedItem.ToString();
            string ResultName = tbPath.Text.ToString();
            ClipPolygonWithLineEvent(LineName, PolygonName, ResultName);
            this.Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "shp files(*.shp)|*.shp";
            saveFileDialog.FileName = "";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = saveFileDialog.FileName;
            }

        }
    }
}
