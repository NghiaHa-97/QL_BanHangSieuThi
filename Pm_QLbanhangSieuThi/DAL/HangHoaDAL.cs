using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class HangHoaDAL
    {
        public  DataTable LayToanBoThongTinHH()
        {
            string query = "dbo.LayToanBoThangTinHH";
            return DatabaseDAL.readDataToTableStoredProcedure(query);

        }

        public bool KtTonTaiHangHoa(string maHang)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE MaHang=@ma";
            if(DatabaseDAL.readDataToTable(query, maHang).Rows.Count==0)
            {
                return false;
            }
            return true;
        }


        public int ThemHangHoa(HangHoa hh)
        {
            string query = "INSERT INTO dbo.HangHoa" +
                            "(MaHang, TenHang, MaLoai, NSX, HSD, SoLuong, Gia, MaNsx, Vitri)" +
                           " VALUES(@ma, @ten, @maloai, @nsx, @hsd, @sl, @gia, @mansx, @vitri)";
            return DatabaseDAL.executeNonQuery(query, hh.maHang, hh.tenHang, hh.maLoai, hh.NSX, hh.HSD, hh.soLuong, hh.gia, hh.maNSX, hh.viTri);
        }

        public int SuaHangHoa(HangHoa hh)
        {
            string query = "UPDATE dbo.HangHoa" +
                            " SET TenHang=@tenhang , MaLoai=@maloai , NSX=@nsx ,HSD=@hsd ,SoLuong=@sl ,Gia=@gia ,MaNsx=@man ,Vitri= @vitri " +
                            "WHERE MaHang =@ma";
            return DatabaseDAL.executeNonQuery(query, hh.tenHang, hh.maLoai, hh.NSX, hh.HSD, hh.soLuong, hh.gia, hh.maNSX, hh.viTri, hh.maHang);
        }
        public int XoaHangHoa(string ma)
        {
            string query = "DELETE dbo.HangHoa WHERE MaHang = @ma";
            return DatabaseDAL.executeNonQuery(query, ma);
        }

        
    }
}
