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
    public class HoaDonDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("HD_SelectAll", null);
        }
        public int InsertData(HoaDonEntity HD)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",HD.MaHD),
                new SqlParameter("MaDT",HD.MaDT),
                new SqlParameter("MaNV",HD.MaNV),
                new SqlParameter("NgayLap",HD.NgayLap),
                new SqlParameter ("KieuHD",HD.KieuHD)
            };
            return conn.ExcuteSQL("Them_HD ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_HD", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From HoaDon", "HD");
        }
        public DataTable TimKiemHD(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public DataTable GetListDoiTac()
        {
            return conn.GetData("Select_DT", null);
        }
        public DataTable GetListNhanVien()
        {
            return conn.GetData("Select_NV", null);
        }
    }
}
