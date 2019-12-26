using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BLL
{
    public class ChungLoaiBLL
    {
        ChungLoaiDAL cl = new ChungLoaiDAL();
        public DataTable LayToanBoChungLoai()
        {
            return cl.LayToanBoChungLoai();
        }
        public bool KiemTraTonTai(string ma)
        {
            return cl.KiemTraTonTai(ma);
        }
        public int ThemChungLoai(ChungLoai ch)
        {
            
            return cl.ThemChungLoai(ch);
        }

        public int SuaChungLoai(ChungLoai ch)
        {
            return cl.SuaChungLoai(ch);
        }
        public int XoaChungLoai(string ma)
        {
            return cl.XoaChungLoai(ma);

        }
    }
}
