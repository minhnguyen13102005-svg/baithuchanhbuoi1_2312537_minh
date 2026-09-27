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
    public partial class frmbai3 : Form
    {
        List<string> list = new List<string>();
        public frmbai3()
        {
            InitializeComponent();
        }

        private void btnThemtu_Click(object sender, EventArgs e)
        {
            var tu = txtTumoi.Text;
            var nghia = txtNghiaCuaTu.Text;
            listBox1.Items.Add(tu);

            list.Add(nghia);

            txtTumoi.Focus();
            txtTumoi.Text = "";
            txtNghiaCuaTu.Text = "";

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtNghiaCuaTu.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtHienthinghia.Text = list[stt];

        }
    }
}
