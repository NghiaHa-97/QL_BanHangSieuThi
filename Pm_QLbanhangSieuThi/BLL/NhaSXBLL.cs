using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;
namespace BLL
{
    public class NhaSXBLL
    {
        NhaSXDAL nsxdal = new NhaSXDAL();
        public DataTable LayToanBoNhaSX()
        {
            return nsxdal.LayToanBoNhaSX();
        }
    }
}
