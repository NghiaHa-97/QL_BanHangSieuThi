using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BLL
{
    public class PhieuNhapBLL
    {
        public DataTable GetListPhieuNhap()
        {
            PhieuNhapDAL dAL = new PhieuNhapDAL();
            var data = dAL.GetListPhieuNhap();
            DatabaseDAL.CloseConnection();
            return data;
        }

        public bool InsertPhieuNhapKho(PhieuNhapKho phieuNhap, DataGridView dataGridView)
        {
            bool result = false;
            PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();
            ChiTietPhieuNhapDAL chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();
            try
            {
                if (!DatabaseDAL.TestConnection())
                {
                    DatabaseDAL.CreatConn();
                }
                DatabaseDAL.Transaction();
                try
                {
                    result = phieuNhapDAL.InsertPhieuNhapHang(phieuNhap);
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        if (dataGridView.Rows[i].Cells["STT"].Value != null)
                        {
                            ChiTietPhieuNhap chiTietPhieu = new ChiTietPhieuNhap();
                            chiTietPhieu.SoChungTu = phieuNhap.SoChungTu;
                            chiTietPhieu.MaHang = dataGridView.Rows[i].Cells["MaHang"].Value?.ToString();
                            chiTietPhieu.TenHang = dataGridView.Rows[i].Cells["TenHang"].Value?.ToString();
                            chiTietPhieu.DonViTinh = dataGridView.Rows[i].Cells["DonVitinh"].Value?.ToString();
                            chiTietPhieu.SoLuongNhap = Convert.ToInt32(dataGridView.Rows[i].Cells["SoLuongNhap"].Value?.ToString());
                            chiTietPhieu.DonGia = Convert.ToInt32(dataGridView.Rows[i].Cells["DonGia"]?.Value?.ToString());
                            chiTietPhieu.ThanhTien = Convert.ToDecimal(dataGridView.Rows[i].Cells["ThanhTien"].Value?.ToString());
                            if (!isEmptyOrNullOrSpecialCharacters(chiTietPhieu.SoChungTu) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.MaHang) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.TenHang) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.DonViTinh) && !isEmptyOrNotNumber(chiTietPhieu.SoLuongNhap) && !isEmptyOrNotNumber(chiTietPhieu.DonGia) && !isEmptyOrNotNumber(chiTietPhieu.ThanhTien))
                            {
                                if(!isBelongToNSX(chiTietPhieu.MaHang, phieuNhap.MaNSX))
                                {
                                    DatabaseDAL.Rollback();
                                    return false;
                                }
                                result = chiTietPhieuNhapDAL.InsertChiTietPhieuNhap(chiTietPhieu);
                            }
                        }
                    }
                    DatabaseDAL.Commit();
                    DatabaseDAL.CloseConnection();
                    return result;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    DatabaseDAL.Rollback();
                    DatabaseDAL.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                DatabaseDAL.CloseConnection();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool isBelongToNSX(string maHang, string maNSX)
        {
            HangHoaDAL dAL = new HangHoaDAL();
            var data = dAL.GetInfoHangHoaByID(maHang);
            if(String.Compare(Convert.ToString(data?.Rows[0][7]), maNSX) == 0)
            {
                return true;
            }
            return false;
        }
      
        public static bool isEmptyOrNullOrSpecialCharacters(object obj)
        {
            string str = convertToUnSign3(obj.ToString());
            if (obj == null || !Regex.IsMatch(str, @"\w"))
            {
                return true;
            }
            return false;
        }

        public static bool isEmptyOrNotNumber(object obj)
        {
            
            if (obj == null || !Regex.IsMatch(obj.ToString(), @"\d"))
            {
                return true;
            }
            return false;
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
   
}
