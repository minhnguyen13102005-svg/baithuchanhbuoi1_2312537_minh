using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapWindowsForms
{
    public partial class Frmchinh : Form
    {
        public Frmchinh()
        {
            InitializeComponent();
        }

        private void tsbbai1_Click(object sender, EventArgs e)
        {
            var form = new frmbai1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var form = new frmbai2();
            form.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            var form = new frmbai3();
            form.ShowDialog();
        }
    }
}
