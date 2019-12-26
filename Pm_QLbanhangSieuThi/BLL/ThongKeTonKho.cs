using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ThongKeTonKho
    {
        public DataTable ThongKeXuatNhapTon(DateTime lastMonth, DateTime currentMonth)
        {
            var data = DatabaseDAL.ReadData("exec USP_KiemKeKho @lastMonth , @currentMonth ", new object[] { lastMonth, currentMonth });
            DatabaseDAL.CloseConnection();
            return data;
        }
    }
}
