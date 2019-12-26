using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class NhanVienDAL
    {
        public DataTable hienThiTatCaNhanVien()
        {
            string query = "SELECT *FROM dbo.NhanVien";

            return DatabaseDAL.ReadDataToTable(query);
        }
        
        public bool KiemTraTonTai(string ma)
        {
            string query = " SELECT * FROM dbo.NhanVien WHERE MaNV = @ma";
            if(DatabaseDAL.ReadDataToTable(query,ma).Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public int themNhanVien(NhanVien nv)
        {
            //string query = string.Format("INSERT dbo.NhanVien(MaNV, TenNV, DiaChi, SDT, NgaySinh,GT, ChucVu, Luongcb, PhuCap, HSLuong, Thuong) VALUES  ( N'{0}' ,  N'{1}' ,  N'{2}' , N'{3}' ,  '{4}' ,N'{5}' ,  N'{6}' ,  {7} , {8} ,  {9} , {10} )",nv.maNV,nv.tenNV,nv.diaChi,nv.sDT,nv.ngaySinh,nv.gT,nv.chucVu,nv.luongCB,nv.phuCap,nv.hSLuong,nv.thuong);
            string query = "INSERT dbo.NhanVien(MaNV, TenNV, DiaChi, SDT, NgaySinh,GT, ChucVu, Luongcb, PhuCap, HSLuong, Thuong) VALUES  ( @manv ,  @tennv ,  @dc , @sdt , @ns  , @gt ,  @cv ,  @lcb , @pc ,  @hsl , @thuong )";
                    
            return DatabaseDAL.ExecuteNonQuery(query, nv.maNV, nv.tenNV, nv.diaChi, nv.sDT, nv.ngaySinh, nv.gT, nv.chucVu, nv.luongCB, nv.phuCap, nv.hSLuong, nv.thuong);
        }

        public int suaNhanVien(NhanVien nv)
        {

            string query = "UPDATE dbo.NhanVien SET TenNV=@ten,DiaChi=@dc,SDT=@sdt,NgaySinh=@ns,GT=@gt,ChucVu=@chv,Luongcb=@lucb,PhuCap=@pc,HSLuong=@hsl,Thuong=@thug WHERE MaNV=@manv";
            return DatabaseDAL.ExecuteNonQuery(query, nv.tenNV, nv.diaChi, nv.sDT, nv.ngaySinh, nv.gT, nv.chucVu, nv.luongCB, nv.phuCap, nv.hSLuong, nv.thuong, nv.maNV);

        }
        public int xoaNhanVien(string maNV)
        {
            string query = "UPDATE dbo.HoaDon SET MaNV=NULL WHERE MaNV=@manv        DELETE FROM dbo.NhanVien WHERE MaNV = @manv";
            return DatabaseDAL.ExecuteNonQuery(query, maNV);

        }

        public DataTable timKiemNhanVien(string maNV)
        {
            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNV='{0}'", maNV);
            return DatabaseDAL.ReadData(query);
        }

        public DataTable GetInfoNhanVien(string maNV)
        {
            string query = "SELECT * FROM dbo.NhanVien WHERE MaNV=@manv";
            return DatabaseDAL.readDataToTable(query, maNV);
        }
    }
}
