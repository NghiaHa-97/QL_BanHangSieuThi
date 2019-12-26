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
    public partial class Form_DsPhieuXuatDiaLog : Form
    {
        public Form_DsPhieuXuatDiaLog()
        {
            InitializeComponent();
            Load_DsPhieuNhap();
        }

        public void Load_DsPhieuNhap()
        {
            PhieuXuatBLL bLL = new PhieuXuatBLL();
            dtgvDsPhieuXuat.DataSource = bLL.GetListPhieuXuat();
        }

        private void btnToLastItem_Click(object sender, EventArgs e)
        {
            dtgvDsPhieuXuat.FirstDisplayedScrollingRowIndex = dtgvDsPhieuXuat.RowCount - 1;
        }
    }
}
