using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Form_NghiepVuKho : Form
    {
        private bool oldDateChecked = false;
        public Form_NghiepVuKho(string maNV)
        {
            InitializeComponent();
            LoadInfoNhanVien(maNV);
            DateTime firstDayOfMonth = new DateTime(dateTimePickerNLP.Value.Year, dateTimePickerNLP.Value.Month, 1);
            txbTuNgay.Text = String.Format("{0}/{1}/{2}", firstDayOfMonth.Month, firstDayOfMonth.Day, firstDayOfMonth.Year);
            Load_ThongkeXuatnhapton();
        }


        public void LoadInfoNhanVien(string maNV)
        {
            NhanVienBLL bLL = new NhanVienBLL();
            txtMaThuKho.Text = maNV;
            txtMaThuKho.Text = bLL.GetInfoNhanVien(maNV).Rows[0][1].ToString();
        }
        void Load_ThongkeXuatnhapton()
        {
            ThongKeTonKho bll = new ThongKeTonKho();
            DateTime firstDayOfMonth = new DateTime(dateTimePickerNLP.Value.Year, dateTimePickerNLP.Value.Month, 1);
            DateTime lastMonth = firstDayOfMonth.AddDays(-1).Date;
            DateTime currentTime = dateTimePickerNLP.Value.Date;
            var data = bll.ThongKeXuatNhapTon(lastMonth, currentTime);
            dtgvXuatNhapTon.DataSource = data;
        }

        private void toolStripBtnNhapKho_Click(object sender, EventArgs e)
        {
            Form_PhieuNhap f = new Form_PhieuNhap("NV01");
            this.Hide();
            f.ShowDialog();
            this.Show();
                
        }

        private void toolStripBtnXuatKho_Click(object sender, EventArgs e)
        {
            Form_PhieuXuat f = new Form_PhieuXuat("NV01");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn thực sự muốn thoát khỏi màn hình kiểm kê kho?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dateTimePickerNLP_ValueChanged(object sender, EventArgs e)
        {
            while (dtgvXuatNhapTon.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dtgvXuatNhapTon.Rows)
                {
                    try
                    {
                        dtgvXuatNhapTon.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            }
            DateTime firstDayOfMonth = new DateTime(dateTimePickerNLP.Value.Year, dateTimePickerNLP.Value.Month, 1);
            txbTuNgay.Text = String.Format("{0}/{1}/{2}", firstDayOfMonth.Month, firstDayOfMonth.Day, firstDayOfMonth.Year);
            Load_ThongkeXuatnhapton();

        }
    }
}
