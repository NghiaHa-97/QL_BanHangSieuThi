using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class HangHoaBLL
    {
        HangHoaDAL hhdal=new HangHoaDAL();
        public DataTable LayToanBoThongTinHH()
        {
            return hhdal.LayToanBoThongTinHH();
        }
        public bool KtTonTaiHangHoa(string maHang)
        {
            return hhdal.KtTonTaiHangHoa(maHang);
        }


        public int ThemHangHoa(HangHoa hh)
        {
            return hhdal.ThemHangHoa(hh);
        }

        public int SuaHangHoa(HangHoa hh)
        {
            return hhdal.SuaHangHoa(hh);
        }
        public int XoaHangHoa(string ma)
        {
            return hhdal.XoaHangHoa(ma);
        }
    }
}
