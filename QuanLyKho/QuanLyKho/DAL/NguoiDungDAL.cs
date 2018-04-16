using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.ENTITY;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKho.DAL
{
    class NguoiDungDAL
    {
        KetNoi conn = new KetNoi();

        public DataTable GetUser(string TaiKhoan, string MatKhau)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", TaiKhoan),
                                    new SqlParameter("MatKhau", MatKhau)};
            return conn.GetData("DangNhap", para);
        }

        public DataTable GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
