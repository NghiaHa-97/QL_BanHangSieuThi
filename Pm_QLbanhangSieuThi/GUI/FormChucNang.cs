using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChucNang : Form
    {
        public FormChucNang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            if (dem == 0)
            {
                FormQLNV nv = new FormQLNV();
                nv.Show();
                dem++;
            }
            else
            {
                return;
            }
        }

        private void FormChucNang_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDN dn = new FormDN();
            dn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQLNhapHang nh = new FormQLNhapHang();
            nh.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormQLNhaSX nsx = new FormQLNhaSX();
            nsx.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLXuatHang xh = new QLXuatHang();
            xh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe();
            tk.Show();
        }
    }
}
