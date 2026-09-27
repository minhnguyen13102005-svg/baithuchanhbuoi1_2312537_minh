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
    public partial class frmbai1 : Form
    {
        public frmbai1()
        {
            InitializeComponent();
        }

        private void frmbai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.DVT = "cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000;


            lblThongbao.Text = hh.HienThi();
        }
    }
}
