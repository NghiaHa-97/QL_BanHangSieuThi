using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class NhaSXDAL
    {
        public DataTable LayToanBoNhaSX()
        {
            string query = "SELECT * FROM dbo.NhaSX";
            return DatabaseDAL.readDataToTable(query);

        }
    }
}
