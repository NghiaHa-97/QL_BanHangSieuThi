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
    public partial class Form_DsPhieuNhapDiaLog : Form
    {
        public Form_DsPhieuNhapDiaLog()
        {
            InitializeComponent();
            Load_DsPhieuNhap();
        }

        public void Load_DsPhieuNhap()
        {
            PhieuNhapBLL bLL = new PhieuNhapBLL();
            dtgvDsPhieuNhap.DataSource = bLL.GetListPhieuNhap();
        }

        private void btnToLastItem_Click(object sender, EventArgs e)
        {
            dtgvDsPhieuNhap.FirstDisplayedScrollingRowIndex = dtgvDsPhieuNhap.RowCount - 1;
        }
    }
}
