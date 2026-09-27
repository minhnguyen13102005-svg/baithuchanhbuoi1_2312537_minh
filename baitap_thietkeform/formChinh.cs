using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_thietkeform
{
    public partial class formChinh : Form
    {
        public formChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmbai1();
            form.ShowDialog();
        }

        private void maiThưToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new frmbai2();
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new frmbai3();
            form.ShowDialog();
        }

        private void tmsiBai4_Click(object sender, EventArgs e)
        {
            var form = new frmbai4();
            form.ShowDialog();
        }
    }
}
