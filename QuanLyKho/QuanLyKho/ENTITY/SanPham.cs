using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ENTITY
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLSP { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public string GhiChu { get; set; }
        public DateTime Ngay { get; set; }
    }
}
