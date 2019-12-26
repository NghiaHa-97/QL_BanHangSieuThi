using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhoBLL
    {
        KhoDAL dAL = new KhoDAL();
        public DataTable GetListKho()
        {
            var data = dAL.GetListKho();
            DatabaseDAL.CloseConnection();
            return data;
        }
    }
}
