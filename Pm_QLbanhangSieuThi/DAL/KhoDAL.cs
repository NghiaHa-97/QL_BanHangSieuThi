using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoDAL
    {
        public DataTable GetListKho()
        {
            string query = "SELECT *FROM Kho";
            return DatabaseDAL.ReadData(query);
        }

    }
}
