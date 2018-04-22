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
    public class LoaiSanPhamDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_XemLoaiSanPham", null);
        }
        public int InsertData(LoaiSanPham sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiSP",sp.MaLoaiSP),
                new SqlParameter("TenLoaiSP",sp.TenLoaiSP),
                new SqlParameter("MoTa",sp.MoTa),
            };
            return conn.ExcuteSQL("SP_ThemLoaiSP ", para);
        }
        public int UpdateData(LoaiSanPham sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiSP",sp.MaLoaiSP),
                new SqlParameter("TenLoaiSP",sp.TenLoaiSP),
                new SqlParameter("MoTa",sp.MoTa),
            };
            return conn.ExcuteSQL("SP_SuaLoaiSP ", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiSP",ID)
        };
            return conn.ExcuteSQL("SP_XoaLoaiSP", para);
        }
        public string TangMa()
        {
            return conn.TangMa3("Select * From LoaiSanPham", "LSP");
        }
        public DataTable TimKiemLoaiSP(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
