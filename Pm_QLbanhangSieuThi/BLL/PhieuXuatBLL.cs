using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhieuXuatBLL
    {
        public DataTable GetListPhieuXuat()
        {
            PhieuXuatDAL dAL = new PhieuXuatDAL();
            var data = dAL.GetListPhieuXuat();
            DatabaseDAL.CloseConnection();
            return data;
        }

        public bool InsertPhieuXuatKho(PhieuXuatKho phieuXuat, DataGridView dataGridView)
        {
            bool result = false;
            PhieuXuatDAL phieuXuatDAL = new PhieuXuatDAL();
            ChiTietPhieuXuatDAL chiTietPhieuXuatDAL = new ChiTietPhieuXuatDAL();
            try
            {
                if (!DatabaseDAL.TestConnection())
                {
                    DatabaseDAL.CreatConn();
                }
                DatabaseDAL.Transaction();
                try
                {
                    result = phieuXuatDAL.InsertPhieuXuatHang(phieuXuat);
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        if (dataGridView.Rows[i].Cells["STT"].Value != null)
                        {
                            ChiTietPhieuXuat chiTietPhieu = new ChiTietPhieuXuat();
                            chiTietPhieu.SoChungTu = phieuXuat.SoChungTu;
                            chiTietPhieu.MaHang = dataGridView.Rows[i].Cells["MaHang"].Value?.ToString();
                            chiTietPhieu.TenHang = dataGridView.Rows[i].Cells["TenHang"].Value?.ToString();
                            chiTietPhieu.DonViTinh = dataGridView.Rows[i].Cells["DonVitinh"].Value?.ToString();
                            chiTietPhieu.SoLuongXuat = Convert.ToInt32(dataGridView.Rows[i].Cells["SoLuongXuat"].Value?.ToString());
                            chiTietPhieu.DonGia = Convert.ToInt32(dataGridView.Rows[i].Cells["DonGia"]?.Value?.ToString());
                            chiTietPhieu.ThanhTien = Convert.ToDecimal(dataGridView.Rows[i].Cells["ThanhTien"].Value?.ToString());
                            if (!isEmptyOrNullOrSpecialCharacters(chiTietPhieu.SoChungTu) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.MaHang) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.TenHang) && !isEmptyOrNullOrSpecialCharacters(chiTietPhieu.DonViTinh) && !isEmptyOrNotNumber(chiTietPhieu.SoLuongXuat) && !isEmptyOrNotNumber(chiTietPhieu.DonGia) && !isEmptyOrNotNumber(chiTietPhieu.ThanhTien))
                            {
                                result = chiTietPhieuXuatDAL.InsertChiTietPhieuXuat(chiTietPhieu);
                            }
                        }
                    }
                    DatabaseDAL.Commit();
                    DatabaseDAL.CloseConnection();
                    return result;
                }
                catch (Exception)
                {
                    DatabaseDAL.Rollback();
                    DatabaseDAL.CloseConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                DatabaseDAL.CloseConnection();
                return false;
            }
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
