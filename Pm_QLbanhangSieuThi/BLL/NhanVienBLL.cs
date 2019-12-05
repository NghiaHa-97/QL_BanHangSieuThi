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
            return nvDAl.hienThiTatCaNhanVien();
        }

        public int themNhanVien(NhanVien nv)
        {
            return nvDAl.themNhanVien(nv);
        }

        public int suaNhanVien(NhanVien nv)
        {
            return nvDAl.suaNhanVien(nv);
        }
        public int xoaNhanVien(string maNV)
        {
            return nvDAl.xoaNhanVien(maNV);
        }
        public DataTable timKiemNhanVien(string maNV)
        {
            return nvDAl.timKiemNhanVien(maNV);
        }
    }
}
