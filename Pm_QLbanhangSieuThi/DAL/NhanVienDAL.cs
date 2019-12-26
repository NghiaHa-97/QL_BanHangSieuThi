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
            return DatabaseDAL.ReadData(query);
        }
        public int themNhanVien(NhanVien nv)
        {
            string query = string.Format("INSERT dbo.NhanVien(MaNV, TenNV, DiaChi, SDT, NgaySinh,GT, ChucVu, Luongcb, PhuCap, HSLuong, Thuong) VALUES  ( N'{0}' ,  N'{1}' ,  N'{2}' , N'{3}' ,  '{4}' ,N'{5}' ,  N'{6}' ,  {7} , {8} ,  {9} , {10} )",nv.maNV,nv.tenNV,nv.diaChi,nv.sDT,nv.ngaySinh,nv.gT,nv.chucVu,nv.luongCB,nv.phuCap,nv.hSLuong,nv.thuong);

            return DatabaseDAL.ExecuteNonQuery(query);
        }

        public int suaNhanVien(NhanVien nv)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET TenNV=N'{0}',DiaChi=N'{1}',SDT='{2}',NgaySinh='{3}',GT=N'{4}',ChucVu=N'{5}',Luongcb={6},PhuCap={7},HSLuong={8},Thuong={9} WHERE MaNV=N'{10}'", nv.tenNV, nv.diaChi, nv.sDT, nv.ngaySinh, nv.gT, nv.chucVu, nv.luongCB, nv.phuCap, nv.hSLuong, nv.thuong, nv.maNV);
            return DatabaseDAL.ExecuteNonQuery(query);

        }
        public int xoaNhanVien(string maNV)
        {
            string query = string.Format("UPDATE dbo.HoaDon SET MaNV=NULL WHERE MaNV='{0}'        DELETE FROM dbo.NhanVien WHERE MaNV = '{0}'", maNV);
            return DatabaseDAL.ExecuteNonQuery(query);

        }

        public DataTable timKiemNhanVien(string maNV)
        {
            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNV='{0}'", maNV);
            return DatabaseDAL.ReadData(query);
        }

        public DataTable GetInfoNhanVien(string maNV)
        {
            string query = String.Format("SELECT *FROM dbo.NhanVien WHERE MaNV='{0}'", maNV);
            return DatabaseDAL.ReadData(query);
        }
    }
}
