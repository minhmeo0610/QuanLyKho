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
    public  class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL dal = new LoaiSanPhamDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public int InsertData(LoaiSanPham sp)
        {
            return dal.InsertData(sp);
        }
        public int UpdateData(LoaiSanPham sp)
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
        public DataTable TimKiemLoaiSP(string strTimKiem)
        {
            return dal.TimKiemLoaiSP(strTimKiem);
        }
    }
}
