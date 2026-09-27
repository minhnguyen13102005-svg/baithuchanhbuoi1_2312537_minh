using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BaitapWindowsForms
{
    internal class HangHoa
    {
        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public string DVT { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public HangHoa()
        {

        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
        }

    }
}
