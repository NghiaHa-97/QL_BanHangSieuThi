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
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQLNV fr = new FormQLNV();
            this.Hide();
            fr.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_PhieuNhap form = new Form_PhieuNhap("NV010");
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn thực sự muốn thoát khỏi chương trình?","", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_PhieuXuat form = new Form_PhieuXuat("NV010");
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_NghiepVuKho f = new Form_NghiepVuKho("NV010");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
