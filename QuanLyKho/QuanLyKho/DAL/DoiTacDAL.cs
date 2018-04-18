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
    public class DoiTacDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable XemThongTinDoiTac()
        {
            return conn.GetData("SP_XemDoiTac");
        }
        public DataTable TimKiemDoiTac(string str)
        {
            return conn.GetData(str);
        }
        public int ThemDoiTac(DoiTac dt)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDoiTac",dt.MaDoiTac),
                new SqlParameter("TenDoiTac",dt.TenDoiTac),
                new SqlParameter("DiaChi",dt.DiaChi),
                new SqlParameter("SoDT",dt.SoDT),
                new SqlParameter("Email",dt.Emaill),
                new SqlParameter("GhiChu",dt.GhiChu),
                new SqlParameter("KieuDoiTac",dt.KieuDoiTac)
            };
            return conn.ExcuteSQL("SP_ThemDoiTac", para);
        }
        public int SuaDoiTac(DoiTac dt)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDoiTac",dt.MaDoiTac),
                new SqlParameter("TenDoiTac",dt.TenDoiTac),
                new SqlParameter("DiaChi",dt.DiaChi),
                new SqlParameter("SoDT",dt.SoDT),
                new SqlParameter("Email",dt.Emaill),
                new SqlParameter("GhiChu",dt.GhiChu),
                new SqlParameter("KieuDoiTac",dt.KieuDoiTac)
            };
            return conn.ExcuteSQL("SP_SuaDoiTac", para);
        }
        public int XoaDoiTac(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDoiTac",id)
            };
            return conn.ExcuteSQL("SP_XoaDoiTac", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From DoiTac", "DT");
        }
    }
}
