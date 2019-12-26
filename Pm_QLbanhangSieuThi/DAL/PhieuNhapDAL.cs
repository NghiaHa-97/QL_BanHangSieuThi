using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuNhapDAL
    {
        public DataTable GetListPhieuNhap()
        {
            var data = DatabaseDAL.ReadData("Select *from dbo.PhieuNhapKho order by SoChungTu");
            return data;
        }

        public bool InsertPhieuNhapHang(PhieuNhapKho phieuNhap )
        {
            int result = DatabaseDAL.ExecuteNonQuery("exec USP_InsertPhieuNhapKho @sochungtu , @makho , @nguoilapphieu , @ngaylapphieu , @nguoigiao , @maNSX", new object[] { phieuNhap.SoChungTu, phieuNhap.MaKho, phieuNhap.NguoiLapPhieu, phieuNhap.NgayLapPhieu, phieuNhap.NguoiGiaoHang, phieuNhap.MaNSX });
            return result > 0;
        }
    }
}
