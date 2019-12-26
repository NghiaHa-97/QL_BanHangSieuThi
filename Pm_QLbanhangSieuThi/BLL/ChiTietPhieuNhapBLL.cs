using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        public bool InsertChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            ChiTietPhieuNhapDAL dAL = new ChiTietPhieuNhapDAL();
            var data = dAL.InsertChiTietPhieuNhap(chiTiet);
            DatabaseDAL.CloseConnection();
            return data;
        }
    }
}
