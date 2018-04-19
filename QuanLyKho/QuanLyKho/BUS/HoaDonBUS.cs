using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.ENTITY;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.DAL;

namespace QuanLyKho.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL da = new HoaDonDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public int InsertData(HoaDonEntity HD)
        {
            return da.InsertData(HD);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiemHD(string strTimKiem)
        {
            return da.TimKiemHD(strTimKiem);
        }
        public DataTable GetListDoiTac()
        {
            return da.GetListDoiTac();
        }
        public DataTable GetListNhanVien()
        {
            return da.GetListNhanVien();
        }
    }
}
