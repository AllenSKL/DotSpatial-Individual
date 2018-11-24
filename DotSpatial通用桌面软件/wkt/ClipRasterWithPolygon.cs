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
    public delegate void ClipRasterWithPolygonDelegate(string raster, string polygon, string result);
    public partial class ClipRasterWithPolygon : Form
    {
        public ClipRasterWithPolygon(List<string> layersName)
        {
            InitializeComponent();
            foreach (string name in layersName)
            {
                this.cbRasterLayer.Items.Add(name);
                this.cbTPolygonLayer.Items.Add(name);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "tiff (*.tiff)|*.tiff";
            saveFileDialog.FileName = "";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = saveFileDialog.FileName;
            }
        }

        public event ClipRasterWithPolygonDelegate ClipRasterWPEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string RasterName = cbRasterLayer.SelectedItem.ToString();
            string PolygonName = cbTPolygonLayer.SelectedItem.ToString();
            string ResultName = tbPath.Text.ToString();
            ClipRasterWPEvent(RasterName, PolygonName, ResultName);
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
