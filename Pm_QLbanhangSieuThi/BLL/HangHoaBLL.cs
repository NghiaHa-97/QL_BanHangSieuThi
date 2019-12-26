using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HangHoaBLL
    {
        HangHoaDAL dAL = new HangHoaDAL();
        public DataTable GetInfoHangByID(string maHang)
        {
            var data = dAL.GetInfoHangHoaByID(maHang);
            DatabaseDAL.CloseConnection();
            return data;
        }

        public DataTable GetListHangHoaByMaNSX(string maNSX)
        {
            var data = dAL.GetListHangHoaByMaNSX(maNSX);
            DatabaseDAL.CloseConnection();
            return data;
        }

        public DataTable SearchHangHoaByNameOrID(string keyword, string maNSX)
        {
            var data = dAL.SearchHangHoaByNameOrID(keyword, maNSX);
            DatabaseDAL.CloseConnection();
            return data;
        }

    }
}
