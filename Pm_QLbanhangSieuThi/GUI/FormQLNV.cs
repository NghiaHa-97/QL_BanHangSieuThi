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
using DTO;

namespace GUI
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
            loadData();
        }
        NhanVienBLL nvBLL = new NhanVienBLL();
        private void loadData()
        {
            if(dataGridViewDSNV.DataSource != null)
            {
                ((DataTable)dataGridViewDSNV.DataSource).Rows.Clear();
                

            }


            dataGridViewDSNV.DataSource = nvBLL.hienThiTatCaNhanVien();


            



            //DataTable dt = nvBLL.hienThiTatCaNhanVien();
            //var list = dt.AsEnumerable().Select(x =>
            //                                        new {a=x.Field<string>("tennv"),
            //                                             b=x.Field<string>("MANV")
            //                                            }
            //                                    )
            //                            .ToList();
            //dataGridViewDSNV.DataSource = list;



        }
        private void themNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.maNV = textBoxMaNV.Text;
            nv.tenNV = textBoxTenNV.Text;
            nv.diaChi = textBoxDiaChi.Text;
            nv.sDT = textBoxSDT.Text;
            nv.ngaySinh = dateTimePickerNS.Value;
            nv.gT = textBoxGT.Text;
            nv.chucVu = textBoxChucvu.Text;
            nv.luongCB = int.Parse(textBoxLuongCB.Text);
            nv.phuCap = int.Parse(textBoxPhuCap.Text);
            nv.hSLuong = int.Parse(textBoxHSLuong.Text);
            nv.thuong = int.Parse(textBoxThuong.Text);
            //nv.tongLuong = int.Parse(textBoxTong.Text);
            if (nvBLL.KiemTraTonTai(nv.maNV) == false)
            {
                if (nvBLL.themNhanVien(nv) != 0)
                {
                    MessageBox.Show("Them Thanh Cong");

                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Nhân viên đã tồn tại");
            }
        }
        private void suaNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.maNV = textBoxMaNV.Text;
            nv.tenNV = textBoxTenNV.Text;
            nv.diaChi = textBoxDiaChi.Text;
            nv.sDT = textBoxSDT.Text;
            nv.ngaySinh = dateTimePickerNS.Value;
            nv.gT = textBoxGT.Text;
            nv.chucVu = textBoxChucvu.Text;
            nv.luongCB = int.Parse(textBoxLuongCB.Text);
            nv.phuCap = int.Parse(textBoxPhuCap.Text);
            nv.hSLuong = int.Parse(textBoxHSLuong.Text);
            nv.thuong = int.Parse(textBoxThuong.Text);
            //nv.tongLuong = int.Parse(textBoxTong.Text);
            if (nvBLL.KiemTraTonTai(nv.maNV) == true) 
            {
                  if (nvBLL.suaNhanVien(nv) != 0)
                  {
                        MessageBox.Show("Sua Thanh Cong");

                        loadData();
                  }
             }
            else
            {
                MessageBox.Show("Nhân viên Không tồn tại");
            }
        }
        private void xoaNhanVien()
        {
            string manv = textBoxMaNV.Text;
            if (manv == null) return;
            if (nvBLL.KiemTraTonTai(manv) == true)
            {
                if (nvBLL.xoaNhanVien(manv) != 0)
                {

                    MessageBox.Show("Xoa Thanh Cong");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {

           // loadData();

        }

        private void dataGridViewDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1) return;
            //DataGridViewRow row = dataGridViewDSNV.Rows[e.RowIndex];
            //textBoxMaNV.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridViewDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewDSNV.Rows[e.RowIndex];
            textBoxMaNV.Text = row.Cells[0].Value.ToString();
            textBoxTenNV.Text= row.Cells[1].Value.ToString();
            textBoxDiaChi.Text = row.Cells[2].Value.ToString();
            textBoxSDT.Text = row.Cells[3].Value.ToString();
            dateTimePickerNS.Value =  DateTime.Parse(row.Cells[4].Value.ToString());
            textBoxGT.Text = row.Cells[5].Value.ToString();
            textBoxChucvu.Text = row.Cells[6].Value.ToString();
            textBoxLuongCB.Text = row.Cells[7].Value.ToString();
            textBoxPhuCap.Text = row.Cells[8].Value.ToString();
            textBoxHSLuong.Text = row.Cells[9].Value.ToString();
            textBoxThuong.Text = row.Cells[10].Value.ToString();
            textBoxTong.Text = row.Cells[11].Value.ToString();

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            
            themNhanVien();


        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

            suaNhanVien();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            themNhanVien();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string maNV = toolStripTextBoxMaNV.Text;
            if (dataGridViewDSNV.DataSource != null) ((DataTable)dataGridViewDSNV.DataSource).Rows.Clear();
            dataGridViewDSNV.DataSource = nvBLL.timKiemNhanVien(maNV);

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xoaNhanVien();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            xoaNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
