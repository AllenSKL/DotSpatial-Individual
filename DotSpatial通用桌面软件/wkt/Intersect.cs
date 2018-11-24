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
    public partial class Intersect : Form
    {
        public delegate void IntersectionDelegate(List<string> inFeatureSetName, string path);
        public Intersect(List<string> layerName)
        {
            InitializeComponent();

            foreach (string name in layerName)
            {
                cbSectInput.Items.Add(name);
            }
        }

        public event IntersectionDelegate IntersectionEvent;
        List<string> lvFeaturesItem = new List<string>();
        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = tbResultPath.Text;
            if (lvFeaturesItem.Count > 0 && !string.IsNullOrEmpty(path))
            {
                IntersectionEvent(lvFeaturesItem, path);
                this.Close();
            }
            else
            {
                MessageBox.Show("请完善参数！", "提醒");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "shp files(*.shp)|*.shp";
            saveFileDialog.FileName = tbResultPath.Text + ".shp";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //System.IO.File.WriteAllLines(saveFileDialog1.FileName, str);   //写到txt文本中   
                tbResultPath.Text = saveFileDialog.FileName;
                // MessageBox.Show("该图层对应的WKT文本保存成功");
            }
        }

        private void cbSectInput_SelectedIndexChanged(object sender, EventArgs e)
        {

            //图层不应该被重复添加
            if (lvFeatures.Items.Count == 0)
            {
                lvFeatures.Items.Add(cbSectInput.SelectedItem.ToString());
                lvFeaturesItem.Add(cbSectInput.SelectedItem.ToString());
            }
            else
            {
                if (!lvFeaturesItem.Contains(cbSectInput.SelectedItem.ToString()))
                {
                    lvFeatures.Items.Add(cbSectInput.SelectedItem.ToString());
                    lvFeaturesItem.Add(cbSectInput.SelectedItem.ToString());
                    //把list View中的图层名转为string存起来
                    //foreach (ListViewItem listViewItem in lvFeatures.Items)
                    //{
                    //    lvFeaturesItem.Add(listViewItem.Text.ToString());
                    //}
                }
            }
        }
    }
}
