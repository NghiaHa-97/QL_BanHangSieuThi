using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        public bool InsertChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            int result = 0;
            result = DatabaseDAL.ExecuteNonQuery("exec USP_InsertChitiet_PhieuNhap @sochungtu , @mahang , @soluong , @dongia , @thanhtien , @donvitinh ", new object[] { chiTiet.SoChungTu, chiTiet.MaHang, chiTiet.SoLuongNhap, chiTiet.DonGia, chiTiet.ThanhTien, chiTiet.DonViTinh });
            return result > 0;
        }
    }
}
