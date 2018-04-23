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
    public class SanPhamDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemSP", null);
        }
        public int InsertData(SanPham sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSP",sp.MaSP),
                new SqlParameter("TenSP",sp.TenSP),
                new SqlParameter("MaLSP",sp.MaLSP),
                new SqlParameter("SoLuong",sp.SoLuong),
                new SqlParameter("Gia",sp.Gia),
                new SqlParameter("GhiChu",sp.GhiChu),
                new SqlParameter("Ngay",sp.Ngay)
            };
            return conn.ExcuteSQL("ThemSP ", para);
        }
        public int UpdateData(SanPham sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSP",sp.MaSP),
                new SqlParameter("TenSP",sp.TenSP),
                new SqlParameter("MaLSP",sp.MaLSP),
                new SqlParameter("SoLuong",sp.SoLuong),
                new SqlParameter("Gia",sp.Gia),
                new SqlParameter("GhiChu",sp.GhiChu),
                new SqlParameter("Ngay",sp.Ngay)
            };
            return conn.ExcuteSQL("SuaSP ", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSP",ID)
        };
            return conn.ExcuteSQL("XoaSP", para);
        }
        public string TangMa()
        {
            return conn.TangMa3("Select * From SanPham", "SP");
        }
        public DataTable TimKiemSP(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
