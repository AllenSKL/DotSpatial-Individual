using DotSpatial.Symbology;
using DotSpatial.Data;
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
    public delegate void VectorToRasterDelegate(string featureName, double cellsize, string filedName, string outputFileName);
    public partial class VectorToRaster : Form
    {
        double cellSize;
        double minCellSizeW;
        double minCellSizeH;

        private List<ILayer> fLayers = new List<ILayer>();//定义Layer类型变量，存储mainForm窗体传进来的layer信息。
        public VectorToRaster(List<ILayer> layers)
        {
            InitializeComponent();
            foreach (Layer layer in layers)
            {
                cbVTRInput.Items.Add(layer.LegendText);
            }
            //使用for循环将layers添加进List
            for (int i = 0; i < layers.Count; i++)
            {
                fLayers.Add(layers[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            sfdRaster.Filter = "tiff file(*.tiff)|*.tiff";
            sfdRaster.FileName = "";
            sfdRaster.AddExtension = true;
            sfdRaster.FilterIndex = 1;
            sfdRaster.RestoreDirectory = true;
            DialogResult dialogResult = sfdRaster.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (sfdRaster.FileName == "" || sfdRaster.FileName == null)
                {
                    MessageBox.Show("请输入文件名！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbRasterPath.Text = sfdRaster.FileName;
                }
            }
        }


        public event VectorToRasterDelegate VTREvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string selectName = cbVTRInput.SelectedItem.ToString();
            string fieldNameWithType = cbFiledName.SelectedItem.ToString();
            string fieldName = fieldNameWithType.Substring(0, fieldNameWithType.IndexOf(" ["));

            double inputCellSize = Convert.ToDouble(tbPixelSize.Text);
            if (inputCellSize < cellSize)
            {
                MessageBox.Show("像元尺寸过小!", "错误");
                return;
            }

            double size = Convert.ToDouble(tbPixelSize.Text);
            string rasterPath = tbRasterPath.Text;
            VTREvent(selectName, size, fieldName, rasterPath);
            this.Close();
        }

        private void cbVTRInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //判断选的那个图层
            for (int i = 0; i < fLayers.Count; i++)
            {
                if (fLayers[i].LegendText.ToString() == cbVTRInput.SelectedItem.ToString())
                {
                    IFeatureSet fs = fLayers[i].DataSet as IFeatureSet;//将Layer类型的转换成FeatureSet类型时，应该转的是Layer的DataSet。
                    DataTable dt = fs.DataTable;
                    if (dt == null)
                    {
                        return;
                    }

                    foreach (DataColumn column in dt.Columns)
                    {
                        cbFiledName.Items.Add(column.ColumnName + " [" + column.DataType.Name + "]");
                    }
                    cbFiledName.SelectedItem = cbFiledName.Items[0];


                    Extent env = fs.Extent;
                    //这个计算出的数值位数较多
                    
                    string minCellSizeWStr = string.Format("{0:N10}", env.Width / 8000);
                    string minCellSizeHStr = string.Format("{0:N10}", env.Height / 8000);
                    minCellSizeW = Convert.ToDouble(minCellSizeWStr);
                    minCellSizeH = Convert.ToDouble(minCellSizeHStr);
                    cellSize = Math.Max(minCellSizeW, minCellSizeH);
                    tbPixelSize.Text = Convert.ToString(cellSize);
                }
            }
        }
    }
}
