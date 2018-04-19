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
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAL da = new ChiTietHoaDonDAL();
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public DataTable GetDataSP(string ID)
        {
            return da.GetDataSP(ID);
        }
        public int InsertData(ChiTietHoaDonEntity CT)
        {
            return da.InsertData(CT);
        }
        public int DeleteData(string MaHD,string MaSP)
        {
            return da.DeleteData(MaHD,MaSP);
        }
        public DataTable GetListSanPham()
        {
            return da.GetListSanPham();
        }
    }
}
