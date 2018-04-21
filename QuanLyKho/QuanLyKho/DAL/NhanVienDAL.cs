﻿using QuanLyKho.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    public class NhanVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemNV", null);
        }
        public int InsertData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("TenNV",NV.TenNV),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter ("SoDT",NV.SoDT),
                new SqlParameter("DiaChi",NV.DiaChi)
            };
            return conn.ExcuteSQL("ThemNV", para);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("TenNV",NV.TenNV),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter ("SoDT",NV.SoDT),
                new SqlParameter("DiaChi",NV.DiaChi)
        };
            return conn.ExcuteSQL("SuaNV ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",ID)
        };
            return conn.ExcuteSQL("XoaNV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhanVien", "NV");
        }
        public DataTable TimKiemNV(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
