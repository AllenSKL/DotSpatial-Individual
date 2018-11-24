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
    public delegate void ClipPolygonWithPolygonDelegate(string WPolygonLayer, string TPolygonLayer, string RPolygonLayer);
    public partial class ClipPolygonWithPolygon : Form
    {
        public ClipPolygonWithPolygon(List<string> layersName)
        {
            InitializeComponent();
            foreach (string name in layersName)
            {
                this.cbWPolygonLayer.Items.Add(name);
                this.cbTPolygonLayer.Items.Add(name);
            }
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

        public event ClipPolygonWithPolygonDelegate ClipPolygonWPEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string WPolyName = cbWPolygonLayer.SelectedItem.ToString();
            string TPolyName = cbTPolygonLayer.SelectedItem.ToString();
            string ResultName = tbPath.Text.ToString();
            ClipPolygonWPEvent(WPolyName, TPolyName, ResultName);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
