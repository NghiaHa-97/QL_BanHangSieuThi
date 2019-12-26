using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa
    {
        [DisplayName("Mã Hàng")]
        public string MaHang { get; set; }
        [DisplayName("Tên Hàng")]
        public string TenHang { get; set; }
        [DisplayName("Ngày sản xuất")]
        public DateTime NSX { get; set; }
        [DisplayName("Hạn sử dụng")]
        public DateTime HSD { get; set; }
        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }
        [DisplayName("Đơn giá")]
        public int Gia { get; set; }
        [DisplayName("Vị trí")]
        public string Vitri { get; set; }
        [DisplayName("Mã loại")]
        public string MaLoai { get; set; }
        [DisplayName("Mã Nhà sản xuất")]
        public string MaNSX { get; set; }
    }
}
