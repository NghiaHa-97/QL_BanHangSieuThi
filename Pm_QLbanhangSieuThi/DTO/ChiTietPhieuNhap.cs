using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public string SoChungTu { get; set; }
        [DisplayName("Mã Hàng")]
        public string MaHang { get; set; }
        [DisplayName("Tên Hàng")]
        public string TenHang { get; set; }
        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }
        [DisplayName("Số lượng nhập")]
        public int? SoLuongNhap { get; set; }
        [DisplayName("Đơn giá")]
        public int? DonGia { get; set; }
        [DisplayName("Thành tiền")]
        public decimal? ThanhTien { get; set; }
    }
}
