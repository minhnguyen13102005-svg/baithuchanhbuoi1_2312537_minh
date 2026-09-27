using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapWindowsForms
{
    public partial class frmbai3 : Form
    {
        public frmbai3()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoa.Text);
            int b = int.Parse(txtsob.Text);
            int n = int.Parse(txtsoN.Text);
            int kq = 0;

            if (rdTinhtongAB.Checked)
                Tinhtoan.Conghaiso(a, b, ref kq);
            else
                kq = Tinhtoan.TongDayso(n);
            lblKQ.Text = kq.ToString();
        }
    }
}
