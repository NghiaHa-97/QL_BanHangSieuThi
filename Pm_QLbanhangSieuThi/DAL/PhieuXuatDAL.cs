using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuXuatDAL
    {
        public DataTable GetListPhieuXuat()
        {
            var data = DatabaseDAL.ReadData("Select *from dbo.PhieuXuatKho order by SoChungTu");
            return data;
        }

        public bool InsertPhieuXuatHang(PhieuXuatKho phieuXuat)
        {
            int result = DatabaseDAL.ExecuteNonQuery("exec USP_InsertPhieuXuatKho @sochungtu , @makho , @nguoilapphieu , @ngaylapphieu , @nguoinhan ", new object[] { phieuXuat.SoChungTu, phieuXuat.MaKho, phieuXuat.NguoiLapPhieu, phieuXuat.NgayLapPhieu, phieuXuat.NguoiNhanHang });
            return result > 0;
        }
    }
}
