﻿using QuanLyKho.DAL;
using QuanLyKho.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL da = new NhanVienDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(NhanVienEntity NV)
        {
            return da.InsertData(NV);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            return da.UpdateData(NV);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemNV(string strTimKiem)
        {
            return da.TimKiemNV(strTimKiem);
        }
    }
}
