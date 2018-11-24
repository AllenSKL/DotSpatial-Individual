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
using DotSpatial.Topology;
namespace wkt
{
    public partial class NewShapefile : Form
    {
        public delegate void transfdelegate(FeatureType layertype, string layername);
        public NewShapefile()
        {
            InitializeComponent();
        }

        FeatureType featureType;
        public event transfdelegate TransfEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnPoint.Checked)
            {
                featureType = FeatureType.Point;
            }
            if (rbtnLine.Checked)
            {
                featureType = FeatureType.Line;
            }
            if (rbtnPolygon.Checked)
            {
                featureType = FeatureType.Polygon;
            }
            if (rbtnMPoint.Checked)
            {
                featureType = FeatureType.MultiPoint;
            }
            if (!string.IsNullOrWhiteSpace(tbFilename.Text) && !tbFilename.Text.ToLower().EndsWith(".shp"))
            {
                tbFilename.Text += @".shp";
            }
            TransfEvent(featureType, tbFilename.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = tbFilename.Text;
            saveFileDialog.Filter= "shp files(*.shp)|*.shp";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;

            if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                tbFilename.Text = saveFileDialog.FileName;
            }
        }
    }
}
