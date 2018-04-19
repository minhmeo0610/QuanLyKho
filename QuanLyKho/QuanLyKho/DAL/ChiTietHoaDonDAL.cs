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
    public class ChiTietHoaDonDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTHD_SelectByID", para);
        }
        public DataTable GetDataSP(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTHD_SelectSanPham", para);
        }
        public int InsertData(ChiTietHoaDonEntity CT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",CT.MaHD),
                new SqlParameter("MaSP",CT.MaSP),
                new SqlParameter("SoLuong",CT.SoLuong),
                new SqlParameter("DonGia",CT.DonGia)
            };
            return conn.ExcuteSQL("Them_CTHD ", para);
        }
        public int DeleteData(string MaHD,string MaSP)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",MaHD),
                new SqlParameter("MaSP",MaSP)
        };
            return conn.ExcuteSQL("Xoa_CTHD", para);
        }
        public DataTable GetListSanPham()
        {
            return conn.GetData("Select_SP", null);
        }
    }
}
