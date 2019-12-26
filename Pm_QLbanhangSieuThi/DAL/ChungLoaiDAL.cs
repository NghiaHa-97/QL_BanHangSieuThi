using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class ChungLoaiDAL
    {
        public DataTable LayToanBoChungLoai()
        {
            string query = "SELECT * FROM dbo.ChungLoai";
            return DatabaseDAL.readDataToTable(query);
        }

        public bool KiemTraTonTai(string ma)
        {
            string query = " SELECT * FROM dbo.ChungLoai  WHERE MaLoai = @ma";
            if(DatabaseDAL.readDataToTable(query,ma).Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public int ThemChungLoai(ChungLoai ch)
        {
            string query = "INSERT INTO dbo.ChungLoai" +
                                     "(MaLoai, TenLoai)" +
                            " VALUES(@ma, @ten) ";
            return DatabaseDAL.executeNonQuery(query, ch.maLoai, ch.tenLoai);
        }

        public int SuaChungLoai(ChungLoai ch)
        {
            string query = " UPDATE dbo.ChungLoai " +
                            " SET TenLoai = @ten " +
                            " WHERE MaLoai = @ma ";
            return DatabaseDAL.executeNonQuery(query, ch.tenLoai, ch.maLoai);
        }
        public int XoaChungLoai(string ma)
        {
            string query = " DELETE dbo.ChungLoai  WHERE MaLoai = @ma";
            return DatabaseDAL.executeNonQuery(query,  ma);

        }


    }
}
