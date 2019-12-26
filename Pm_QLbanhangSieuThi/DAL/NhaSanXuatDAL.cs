using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaSanXuatDAL
    {
        public DataTable GetListNSX()
        {
            string query = "SELECT *FROM NhaSX";
            return DatabaseDAL.ReadData(query);
        }
    }
}
