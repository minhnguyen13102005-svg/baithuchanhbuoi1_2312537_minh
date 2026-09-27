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
    public partial class frmbai2 : Form
    {
        public frmbai2()
        {
            InitializeComponent();
        }

        private void rdChuyenkhoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDongia.Text = "100000";
                    break;
                case 1:
                    txtDongia.Text = "200000";
                    break;
                case 2:
                    txtDongia.Text = "150000";
                    break;
            }    
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(txtDongia.Text);
            int soluong = int.Parse(txtSoluong.Text);
            double thanhtien = dongia * soluong;

            if (rdChuyenkhoan.Checked)
            {
                thanhtien = dongia * soluong*0.95;
            }
            lblSotien.Text = thanhtien.ToString();
        }
    }
}
