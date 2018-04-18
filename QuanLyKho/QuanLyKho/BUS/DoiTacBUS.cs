using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DAL;
using QuanLyKho.ENTITY;
using System.Data;
namespace QuanLyKho.BUS
{
    public class DoiTacBUS
    {
        DoiTacDAL doitacdal = new DoiTacDAL();
        public DataTable XemThongTinDoiTac()
        {
            return doitacdal.XemThongTinDoiTac();
        }
        public DataTable TimKiemDoiTac(string str)
        {
            return doitacdal.TimKiemDoiTac(str);
        }
     
        public int ThemDoiTac(DoiTac dt)
        {
            return doitacdal.ThemDoiTac(dt);
        }
        public int SuaDoiTac(DoiTac dt)
        {
            return doitacdal.SuaDoiTac(dt);
        }
        public int XoaDoiTac(string id)
        {
            return doitacdal.XoaDoiTac(id);
        }
        public string TangMa()
        {
            return doitacdal.TangMa();
        }
    }
}
