using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Form_PhieuNhap : Form
    {
        public Form_PhieuNhap(string maNV)
        {
            InitializeComponent();
            KhoiTao_dtgvDsHangNhap();
            LoadNSX();
            LoadKho();
            LoadInfoNhanVien(maNV);
        }

        public void KhoiTao_dtgvDsHangNhap()
        {
            ChiTietPhieuNhap[] phieuNhaps = new ChiTietPhieuNhap[10];
            for (int i = 0; i < phieuNhaps.Length; i++)
            {
                phieuNhaps[i] = new ChiTietPhieuNhap();
            }
            //DataGridBoolColumn column = new DataGridBoolColumn();
            //column.he
            dtgvDsHangNhap.Columns.Add("STT", "STT");
            dtgvDsHangNhap.DataSource = phieuNhaps;
            dtgvDsHangNhap.Columns[0].Width = 50;
            dtgvDsHangNhap.Columns[1].Visible = false;
            dtgvDsHangNhap.Columns[3].Width = 200;
            dtgvDsHangNhap.Columns[3].ReadOnly = true;
            dtgvDsHangNhap.Columns[7].ReadOnly = true;
            dtgvDsHangNhap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn item in dtgvDsHangNhap.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        public void LoadNSX()
        {
            NhaSanXuatBLL bLL = new NhaSanXuatBLL();
            cbNhaSX.DataSource = bLL.GetListNSX();
            cbNhaSX.DisplayMember = "TenNsx";
        }

        public void LoadKho()
        {
            KhoBLL bLL = new KhoBLL();
            cbKhoNhap.DataSource = bLL.GetListKho();
            cbKhoNhap.DisplayMember = "TenKho";
        }

        public void LoadInfoNhanVien(string maNV)
        {
            NhanVienBLL bLL = new NhanVienBLL();
            txbMaNV.Text = maNV;
            txbTenNV.Text = bLL.GetInfoNhanVien(maNV).Rows[0][1].ToString();
        }

        private void btnGhiSo_Click(object sender, EventArgs e)
        {
            PhieuNhapBLL bLL = new PhieuNhapBLL();
            PhieuNhapKho phieuNhap = new PhieuNhapKho();
            phieuNhap.SoChungTu = txbSohieu.Text;
            phieuNhap.MaKho = ((DataRowView)cbKhoNhap.SelectedItem)["MaKho"].ToString();
            phieuNhap.NgayLapPhieu = dateTimePickerNgayLapPhieu.Value.Date;
            phieuNhap.NguoiLapPhieu = txbTenNV.Text;
            phieuNhap.NguoiGiaoHang = txbNguoigiao.Text;
            phieuNhap.MaNSX = ((DataRowView)cbNhaSX.SelectedItem)["MaNsx"].ToString();
            if (bLL.InsertPhieuNhapKho( phieuNhap, dtgvDsHangNhap))
            {
                MessageBox.Show("Đã thêm thành công phiếu nhập!");
            }
            else
            {
                MessageBox.Show("Không thể thêm phiếu nhập!");
            }
        }

     
        private void dtgvDsHangNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDsHangNhap.Columns[e.ColumnIndex].Name == "DonGia" || dtgvDsHangNhap.Columns[e.ColumnIndex].Name == "SoLuongNhap")
            {
                if(dtgvDsHangNhap.Rows[e.RowIndex].Cells["SoLuongNhap"].Value != null && dtgvDsHangNhap.Rows[e.RowIndex].Cells["DonGia"].Value != null)
                {
                    dtgvDsHangNhap.Rows[e.RowIndex].Cells["ThanhTien"].Value = (Convert.ToDecimal(dtgvDsHangNhap.Rows[e.RowIndex].Cells["SoLuongNhap"].Value.ToString()) * Convert.ToDecimal(dtgvDsHangNhap.Rows[e.RowIndex].Cells["DonGia"].Value.ToString())).ToString();
                }
            }
            else if(dtgvDsHangNhap.Columns[e.ColumnIndex].Name == "MaHang")
            {
                if(!String.IsNullOrEmpty(dtgvDsHangNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) && !String.IsNullOrWhiteSpace(dtgvDsHangNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    HangHoaBLL bLL = new HangHoaBLL();
                    var data = bLL.GetInfoHangByID(dtgvDsHangNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    dtgvDsHangNhap.Rows[e.RowIndex].Cells["TenHang"].Value = data?.Rows[0][1].ToString();
                }
            }
        }

        private void btnDetailNSX_Click(object sender, EventArgs e)
        {
            var _NhaNS = (DataRowView)cbNhaSX.SelectedItem;
            Form_DetailNSX f = new Form_DetailNSX(_NhaNS);
            f.Show();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn thực sự muốn huỷ bỏ việc thêm phiếu nhập", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDsPhieuNhap_Click(object sender, EventArgs e)
        {
            Form_DsPhieuNhapDiaLog f = new Form_DsPhieuNhapDiaLog();
            f.Show();
        }
    }
}
