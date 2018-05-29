using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI_QLST
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        SanPham_BUS bus_SanPham = new SanPham_BUS();

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmHoaDon fHoaDon = new frmHoaDon();
            fHoaDon.Show();
            this.Close();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
        }

        private void dtgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvHangHoa.CurrentCell.RowIndex;

            txtTenSanPham.Text = dtgvHangHoa.Rows[r].Cells[2].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Clear();
            txtSoLuongMua.Clear();
        }
    }
}
