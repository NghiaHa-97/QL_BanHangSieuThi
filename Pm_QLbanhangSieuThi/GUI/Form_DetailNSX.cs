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
    public partial class Form_DetailNSX : Form
    {
        public Form_DetailNSX(DataRowView nhaSX)
        {
            InitializeComponent();
            Load_Form(nhaSX);
        }

        public void Load_Form(DataRowView nhaSX)
        {
            txbMaNSX.Text = nhaSX["MaNsx"].ToString();
            txbTenNSX.Text = nhaSX["TenNsx"].ToString();
            txbDiaChi.Text = nhaSX["DiaChi"].ToString();
            txbEmail.Text = nhaSX["Email"].ToString();
            txbSDT.Text = nhaSX["SDT"].ToString();
            Load_DsHangHoa(txbMaNSX.Text);
        }

        public void Load_DsHangHoa(string maNSX)
        {
            HangHoaBLL bLL = new HangHoaBLL();
            dtgvDsHangHoa.DataSource = bLL.GetListHangHoaByMaNSX(maNSX);
            foreach (DataGridViewColumn item in dtgvDsHangHoa.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HangHoaBLL bLL = new HangHoaBLL();
            string keyword = txbKeyword.Text;
            dtgvDsHangHoa.DataSource = bLL.SearchHangHoaByNameOrID(keyword, txbMaNSX.Text);
            foreach (DataGridViewColumn item in dtgvDsHangHoa.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
