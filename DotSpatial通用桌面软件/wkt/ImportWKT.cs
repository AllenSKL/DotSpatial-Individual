using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace wkt
{
    public delegate void transfdelegate(string value1);

    public partial class ImportWKT : Form
    {
        public ImportWKT()
        {
            InitializeComponent();
        }
        public event transfdelegate TransfEvent;
        public void importWKTtxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt file(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                textBox1.Text = File.ReadAllText(filename);
                TransfEvent(filename);
                this.Close();
            }
            else
            {

            }
        }

        
    }
}
