using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvDAl = new NhanVienDAL();
        public DataTable hienThiTatCaNhanVien()
        {
            var data = nvDAl.hienThiTatCaNhanVien();
            DatabaseDAL.CloseConnection();
            return data;
        }
        public bool KiemTraTonTai(string ma)
        {
            return nvDAl.KiemTraTonTai(ma);
        }
        public int themNhanVien(NhanVien nv)
        {
            var data = nvDAl.themNhanVien(nv);
            DatabaseDAL.CloseConnection();
            return data;
        }

        public int suaNhanVien(NhanVien nv)
        {
            var data = nvDAl.suaNhanVien(nv);
            DatabaseDAL.CloseConnection();
            return data;
        }
        public int xoaNhanVien(string maNV)
        {
            var data = nvDAl.xoaNhanVien(maNV);
            DatabaseDAL.CloseConnection();
            return data;
        }
        public DataTable timKiemNhanVien(string maNV)
        {
            var data = nvDAl.timKiemNhanVien(maNV);
            DatabaseDAL.CloseConnection();
            return data;
        }

        public DataTable GetInfoNhanVien(string maNV)
        {
            var data = nvDAl.GetInfoNhanVien(maNV);
            DatabaseDAL.CloseConnection();
            return data;
        }
    }
}
