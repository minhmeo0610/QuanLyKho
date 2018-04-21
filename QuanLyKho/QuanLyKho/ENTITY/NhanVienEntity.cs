using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ENTITY
{
    public class NhanVienEntity
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }

        public NhanVienEntity()
        {
            MaNV = "";
            TenNV = "";
            NgaySinh = DateTime.Parse("01/01/1997");
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
        public NhanVienEntity(string _MaNV, string _TenNV, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _SoDT)
        {
            MaNV = _MaNV;
            TenNV = _TenNV;
            NgaySinh = _NgaySinh;
            GioiTinh = _GioiTinh;
            DiaChi = _DiaChi;
            SoDT = _SoDT;
        }
    }
}
