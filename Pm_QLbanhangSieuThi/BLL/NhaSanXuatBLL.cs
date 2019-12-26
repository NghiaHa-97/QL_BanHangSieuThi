using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhaSanXuatBLL
    {
        NhaSanXuatDAL dAL = new NhaSanXuatDAL();

        public DataTable GetListNSX()
        {
            var data = dAL.GetListNSX();
            DatabaseDAL.CloseConnection();
            return data;
        }
    }
}
