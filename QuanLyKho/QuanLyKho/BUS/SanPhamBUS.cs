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
    public class SanPhamBUS
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }
        public int InsertData(SanPham sp)
        {
            return dal.InsertData(sp);
        }
        public int UpdateData(SanPham sp)
        {
            return dal.UpdateData(sp);
        }

        public int DeleteData(string ID)
        {
            return dal.DeleteData(ID);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
        public DataTable TimKiemSP(string strTimKiem)
        {
            return dal.TimKiemSP(strTimKiem);
        }
    }
}
