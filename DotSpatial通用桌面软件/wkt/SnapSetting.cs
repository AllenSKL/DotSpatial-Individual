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
    public partial class SnapSetting : Form
    {
        public SnapSetting()
        {
            InitializeComponent();
        }

        private bool canSnap
        {
            get { return cbSnapToggle.Checked; }
            set { cbSnapToggle.Checked = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool can = cbSnapToggle.Checked;
            canSnap = can;
        }
    }
}

