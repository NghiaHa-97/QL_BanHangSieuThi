using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangHoaDAL
    {
        public DataTable GetInfoHangHoaByID(string maHang)
        {
            string query = String.Format("SELECT *FROM dbo.HangHoa WHERE MaHang='{0}'", maHang);
            return DatabaseDAL.ReadData(query);
        }

        public DataTable GetListHangHoaByMaNSX(string maNSX)
        {
            string query = String.Format("Select *from dbo.HangHoa Where MaNsx='{0}'", maNSX);
            return DatabaseDAL.ReadData(query);
        }

        public DataTable SearchHangHoaByNameOrID(string keyword, string maNSX)
        {
            var query = String.Format("select *from dbo.HangHoa Where (MaHang like '%{0}%' or TenHang like '%{1}%') and MaNsx='{2}'", keyword, keyword, maNSX);
            return DatabaseDAL.ReadData(query);
        }
    }
}
