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
    public partial class frmbai2 : Form
    {
        public frmbai2()
        {
            InitializeComponent();
        }
 
        private void btnChonhang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBohang_Click(object sender, EventArgs e)
        {
           listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int Sotien = 0;
            foreach(string hang in listBox2.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        Sotien += 100000;
                        break;
                    case "Bàn Phím":
                        Sotien += 150000;
                        break;
                    case "Máy in":
                        Sotien += 2000000;
                        break;
                    case "USB Kingmax":
                        Sotien += 200000;
                        break;

                }
                lblSoTien.Text = Sotien + "  đồng";
            }    
        }
    }
}
