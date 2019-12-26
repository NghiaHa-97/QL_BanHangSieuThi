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
    public partial class Form_PhieuXuat : Form
    {
        public Form_PhieuXuat(string maNV)
        {
            InitializeComponent();
            KhoiTao_dtgvDsHangNhap();
            LoadKho();
            LoadInfoNhanVien(maNV);
        }

        public void KhoiTao_dtgvDsHangNhap()
        {
            ChiTietPhieuXuat[] phieuXuats = new ChiTietPhieuXuat[10];
            for (int i = 0; i < phieuXuats.Length; i++)
            {
                phieuXuats[i] = new ChiTietPhieuXuat();
            }
            dtgvDsHangXuat.Columns.Add("STT", "STT");
            dtgvDsHangXuat.DataSource = phieuXuats;
            dtgvDsHangXuat.Columns[0].Width = 50;
            dtgvDsHangXuat.Columns[1].Visible = false;
            dtgvDsHangXuat.Columns[3].Width = 200;
            dtgvDsHangXuat.Columns[3].ReadOnly = true;
            dtgvDsHangXuat.Columns[7].ReadOnly = true;
            dtgvDsHangXuat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn item in dtgvDsHangXuat.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

       
        public void LoadKho()
        {
            KhoBLL bLL = new KhoBLL();
            cbKhoNhap.DataSource = bLL.GetListKho();
            cbKhoNhap.DisplayMember = "TenKho";
            txbDiaDiem.Text = ((DataRowView)cbKhoNhap.SelectedItem)?["DiaDiem"].ToString();
        }

        public void LoadInfoNhanVien(string maNV)
        {
            NhanVienBLL bLL = new NhanVienBLL();
            txbMaNV.Text = maNV;
            txbTenNV.Text = bLL.GetInfoNhanVien(maNV).Rows[0][1].ToString();
        }

        private void btnGhiSo_Click(object sender, EventArgs e)
        {
            PhieuXuatBLL bLL = new PhieuXuatBLL();
            PhieuXuatKho phieuXuat = new PhieuXuatKho();
            phieuXuat.SoChungTu = txbSohieu.Text;
            phieuXuat.MaKho = ((DataRowView)cbKhoNhap.SelectedItem)["MaKho"].ToString();
            phieuXuat.NgayLapPhieu = dateTimePickerNgayLapPhieu.Value.Date;
            phieuXuat.NguoiLapPhieu = txbTenNV.Text;
            phieuXuat.NguoiNhanHang = txbNguoigiao.Text;
            if (bLL.InsertPhieuXuatKho(phieuXuat, dtgvDsHangXuat))
            {
                MessageBox.Show("Đã thêm thành công phiếu xuất!");
            }
            else
            {
                MessageBox.Show("Không thể thêm phiếu xuất!");
            }
        }

        private void dtgvDsHangNhap_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDsHangNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDsHangXuat.Columns[e.ColumnIndex].Name == "DonGia" || dtgvDsHangXuat.Columns[e.ColumnIndex].Name == "SoLuongXuat")
            {
                if(dtgvDsHangXuat.Rows[e.RowIndex].Cells["SoLuongXuat"].Value != null && dtgvDsHangXuat.Rows[e.RowIndex].Cells["DonGia"].Value != null)
                {
                    dtgvDsHangXuat.Rows[e.RowIndex].Cells["ThanhTien"].Value = (Convert.ToDecimal(dtgvDsHangXuat.Rows[e.RowIndex].Cells["SoLuongXuat"].Value.ToString()) * Convert.ToDecimal(dtgvDsHangXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString())).ToString();
                }
            }
            else if(dtgvDsHangXuat.Columns[e.ColumnIndex].Name == "MaHang")
            {
                if(!String.IsNullOrEmpty(dtgvDsHangXuat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) && !String.IsNullOrWhiteSpace(dtgvDsHangXuat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    HangHoaBLL bLL = new HangHoaBLL();
                    var data = bLL.GetInfoHangByID(dtgvDsHangXuat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    dtgvDsHangXuat.Rows[e.RowIndex].Cells["TenHang"].Value = data?.Rows[0][1].ToString();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn thực sự muốn huỷ bỏ việc thêm phiếu xuất", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDsPhieuXuat_Click(object sender, EventArgs e)
        {
            Form_DsPhieuXuatDiaLog f = new Form_DsPhieuXuatDiaLog();
            f.Show();
        }
    }
}
