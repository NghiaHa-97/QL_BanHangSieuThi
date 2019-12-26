using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietPhieuXuatDAL
    {
        public bool InsertChiTietPhieuXuat(ChiTietPhieuXuat chiTiet)
        {
            int result = 0;
            result = DatabaseDAL.ExecuteNonQuery("exec USP_InsertChitiet_PhieuXuat @sochungtu , @mahang , @soluong , @dongia , @thanhtien , @donvitinh ", new object[] { chiTiet.SoChungTu, chiTiet.MaHang, chiTiet.SoLuongXuat, chiTiet.DonGia, chiTiet.ThanhTien, chiTiet.DonViTinh });
            return result > 0;
        }
    }
}
