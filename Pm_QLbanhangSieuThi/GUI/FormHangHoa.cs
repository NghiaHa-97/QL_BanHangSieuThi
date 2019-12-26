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
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
            LoadHangHoa();
            LoadDanhMuc();
            LoadNSX();
        }
        DataTable dtb = new DataTable();
        HangHoaBLL hhbll = new HangHoaBLL();
        ChungLoaiBLL clbll = new ChungLoaiBLL();
        NhaSXBLL nsxbll = new NhaSXBLL();
        List<ChungLoai> chl = new List<ChungLoai>();
        List<NhaSX> nsx = new List<NhaSX>();

        public void LoadHangHoa()
        {
            listViewDSHH.Items.Clear();
            dtb = hhbll.LayToanBoThongTinHH();
            var hh = dtb.AsEnumerable()
                        .Select(x=>new 
                        {
                            maHang=x.Field<string>("maHang"),
                            tenHang=x.Field<string>("tenHang"),
                            tenLoai=x.Field<string>("tenLoai"),
                            nSX=x.Field<DateTime>("nSX"),
                            hSD=x.Field<DateTime>("hSD"),
                            soLuong=x.Field<int>("soLuong"),
                            gia=x.Field<int>("gia"),
                            tenNSX=x.Field<string>("tenNSX"),
                            viTri=x.Field<string>("viTri"),
                            
                        })
                        .ToList();

            
            
            hh.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.maHang);
                lt.SubItems.Add(x.tenHang);
                lt.SubItems.Add(x.tenLoai);
                lt.SubItems.Add(x.nSX + "");
                lt.SubItems.Add(x.hSD + "");
                lt.SubItems.Add(x.soLuong + "");
                lt.SubItems.Add(x.gia + "");
                lt.SubItems.Add(x.tenNSX);
                lt.SubItems.Add(x.viTri);
                
                listViewDSHH.Items.Add(lt);
            });
                         
        }

        public void LoadDanhMuc()
        {
            listBoxDM.Items.Clear();
            dtb = clbll.LayToanBoChungLoai();
            chl = dtb.AsEnumerable().Select(x =>

                  new ChungLoai
                  {
                      maLoai = x.Field<string>("maLoai"),
                      tenLoai = x.Field<string>("tenLoai")
                  })
                  .ToList();
            chl.ForEach(x =>
            {
                listBoxDM.Items.Add(x.maLoai + " - " + x.tenLoai);
                comboBoxDM.Items.Add(x.maLoai + " - " + x.tenLoai);
            });
            
        }

       
        public void LoadNSX()
        {
            dtb = nsxbll.LayToanBoNhaSX();
            nsx = dtb.AsEnumerable().Select(x => new NhaSX
            {
                maNSX = x.Field<string>("maNSX"),
                tenNSX = x.Field<string>("tenNSX"),
                diaChi=x.Field<string>("diaChi"),
                sDT=x.Field<string>("sDT"),
                email=x.Field<string>("email"),


            }).ToList();

            nsx.ForEach(x=> {
                comboBoxNhaSX.Items.Add(x.maNSX + " - " + x.tenNSX);
            });
        }

        private void listBoxDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDM.SelectedIndex==-1)
            {
                return;
            }
            listViewDSHH.Items.Clear();
            string ma = listBoxDM.SelectedItem.ToString().Split('-')[0].Split(' ')[0];
            dtb = hhbll.LayToanBoThongTinHH();
            var hh = dtb.AsEnumerable() 
                        .Where(x=>x.Field<string>("maLoai")==ma)
                        .Select(x => new
                        {
                            maHang = x.Field<string>("maHang"),
                            tenHang = x.Field<string>("tenHang"),
                            tenLoai = x.Field<string>("tenLoai"),
                            nSX = x.Field<DateTime>("nSX"),
                            hSD = x.Field<DateTime>("hSD"),
                            soLuong = x.Field<int>("soLuong"),
                            gia = x.Field<int>("gia"),
                            tenNSX = x.Field<string>("tenNSX"),
                            viTri = x.Field<string>("viTri"),
                            //maLoai=x.Field<string>("maLoai")

                        })
                        .ToList();

            //var listhh = (from i in hh
            //             where i.maLoai==ma
            //             select i).ToList();

            hh.ForEach(x =>
            {
                ListViewItem lt = new ListViewItem(x.maHang);
                lt.SubItems.Add(x.tenHang);
                lt.SubItems.Add(x.tenLoai);
                lt.SubItems.Add(x.nSX + "");
                lt.SubItems.Add(x.hSD + "");
                lt.SubItems.Add(x.soLuong + "");
                lt.SubItems.Add(x.gia + "");
                lt.SubItems.Add(x.tenNSX);
                lt.SubItems.Add(x.viTri);
                //lt.SubItems.Add(x.maLoai);
                listViewDSHH.Items.Add(lt);
            });
           
        }

        private void listViewDSHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDSHH.SelectedItems.Count<=0)
            {
                return;
            }
            ListViewItem lit = listViewDSHH.SelectedItems[0];
            string ma = lit.Text;
            dtb = hhbll.LayToanBoThongTinHH();
            var hh = dtb.AsEnumerable()
                        .Where(x => x.Field<string>("maHang") == ma)
                        .Select(x => new
                        {
                            maHang = x.Field<string>("maHang"),
                            tenHang = x.Field<string>("tenHang"),
                            tenLoai = x.Field<string>("tenLoai"),
                            nSX = x.Field<DateTime>("nSX"),
                            hSD = x.Field<DateTime>("hSD"),
                            soLuong = x.Field<int>("soLuong"),
                            gia = x.Field<int>("gia"),
                            tenNSX = x.Field<string>("tenNSX"),
                            viTri = x.Field<string>("viTri"),
                            maLoai = x.Field<string>("maLoai"),
                            maNSX = x.Field<string>("maNSX")

                        })
                        .ToList();
            hh.ForEach(x =>
            {
                textBoxMaHang.Text = x.maHang;
                textBoxTenHang.Text = x.tenHang;
                comboBoxDM.Text = x.maLoai + " - " + x.tenLoai;
                dateTimePickerNSX.Value = x.nSX;
                dateTimePickerNSX.Text = x.nSX.ToString();
                dateTimePickerHSD.Value = x.hSD;
                dateTimePickerHSD.Text = x.hSD.ToString();
                textBoxSoLuong.Text = x.soLuong.ToString();
                textBoxGia.Text = x.gia.ToString();
                comboBoxNhaSX.Text = x.maNSX + " - " + x.tenNSX;
                textBoxViTri.Text = x.viTri;
            });

        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.maHang = textBoxMaHang.Text;
            hh.tenHang = textBoxTenHang.Text;
            hh.maLoai = comboBoxDM.Text.Split('-')[0];
            hh.NSX =DateTime.Parse( dateTimePickerNSX.Text);
            hh.HSD = DateTime.Parse(dateTimePickerHSD.Text);
            hh.soLuong=int.Parse(textBoxSoLuong.Text);
            hh.gia= int.Parse(textBoxGia.Text);
            hh.maNSX=comboBoxNhaSX.Text.Split('-')[0];
            hh.viTri =textBoxViTri.Text;
            if(hhbll.KtTonTaiHangHoa(hh.maHang)==true)
            {
                MessageBox.Show("Hàng hóa này đã bị trùng mã");
            }
            else
            {
                if(hhbll.ThemHangHoa(hh)>0)
                {
                    MessageBox.Show("Thêm Thành công");
                    LoadHangHoa();
                }
                
            }
        }

        private void buttonSuaSP_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.maHang = textBoxMaHang.Text;
            hh.tenHang = textBoxTenHang.Text;
            hh.maLoai = comboBoxDM.Text.Split('-')[0];
            hh.NSX = DateTime.Parse(dateTimePickerNSX.Text);
            hh.HSD = DateTime.Parse(dateTimePickerHSD.Text);
            hh.soLuong = int.Parse(textBoxSoLuong.Text);
            hh.gia = int.Parse(textBoxGia.Text);
            hh.maNSX = comboBoxNhaSX.Text.Split('-')[0];
            hh.viTri = textBoxViTri.Text;
            if (hhbll.KtTonTaiHangHoa(hh.maHang) == true)
            {
                if(hhbll.SuaHangHoa(hh)>0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    LoadHangHoa();
                }
            }
            else
            {
                MessageBox.Show("Mã mặt hàng không đúng");

            }
        }

        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            string ma = textBoxMaHang.Text;
            if (hhbll.KtTonTaiHangHoa(ma) == true)
            {
                if (hhbll.XoaHangHoa(ma) > 0)
                {
                    MessageBox.Show("Xóa Hàng Hóa Thành Công");
                    LoadHangHoa();
                }
            }
            else
            {
                MessageBox.Show("Mặt hàng không tồn tại");

            }
        }

        private void buttonThemDM_Click(object sender, EventArgs e)
        {
            FormChungLoai fcl = new FormChungLoai();
            if(fcl.ShowDialog()==DialogResult.OK)
            {
                ChungLoai cl = new ChungLoai();
                cl.maLoai = fcl.textBoxMaLoai1.Text;
                cl.tenLoai = fcl.textBoxTenLoai1.Text;
                if(clbll.KiemTraTonTai(cl.maLoai)==false)
                {
                    if(clbll.ThemChungLoai(cl)>0)
                    {
                        MessageBox.Show("Them Thành công Danh mục");
                        LoadDanhMuc();
                    }
                    
                     
                }
                else
                {
                    MessageBox.Show("Da ton tai danh muc");
                }
            }
        }

        private void buttonSuaDM_Click(object sender, EventArgs e)
        {
            FormChungLoai fcl = new FormChungLoai();
            if (listBoxDM.SelectedIndex != -1)
            {
                fcl.textBoxMaLoai1.Text = listBoxDM.SelectedItem.ToString().Split('-')[0];
                fcl.textBoxTenLoai1.Text = listBoxDM.SelectedItem.ToString().Split('-')[1];
            }
            if (fcl.ShowDialog() == DialogResult.OK)
            {
                
                ChungLoai cl = new ChungLoai();
                cl.maLoai = fcl.textBoxMaLoai1.Text;
                cl.tenLoai = fcl.textBoxTenLoai1.Text;
                if (clbll.KiemTraTonTai(cl.maLoai) == true)
                {
                    if (clbll.SuaChungLoai(cl) > 0)
                    {
                        MessageBox.Show("SỬa Thành công Danh mục");
                        LoadDanhMuc();
                    }


                }
                else
                {
                    MessageBox.Show("Danh mục không tồn tại");
                }
            }
        }

        private void buttonXoaDM_Click(object sender, EventArgs e)
        {
            if(listBoxDM.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục nào tren danh sách");

            }
            else
            {
                string ma = listBoxDM.SelectedItem.ToString().Split('-')[0];
                if(clbll.XoaChungLoai(ma)>0)
                {
                    MessageBox.Show("Bjan đã xóa thành công");
                    LoadDanhMuc();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadHangHoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }
    }
}
