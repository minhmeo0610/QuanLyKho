using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ENTITY
{
    public class LoaiSanPham
    {
        private string _MaLoaiSP;
        private string _TenLoaiSP;
        private string _MoTa;

        public string MaLoaiSP
        {
            get
            {
                return _MaLoaiSP;
            }

            set
            {
                _MaLoaiSP = value;
            }
        }

        public string TenLoaiSP
        {
            get
            {
                return _TenLoaiSP;
            }

            set
            {
                _TenLoaiSP = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _MoTa;
            }

            set
            {
                _MoTa = value;
            }
        }
    }
}
