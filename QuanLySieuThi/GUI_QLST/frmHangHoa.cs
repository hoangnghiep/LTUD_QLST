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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        SanPham_BUS bus_SanPham = new SanPham_BUS();
        string lenh;
        string ADD = "add";
        string EDIT = "edit";

        private int id_SanPham;
        private string maSanPham;
        private string tenSanPham;
        private int giaSanPham;
        private int soLuongSP;

        public void showButton(bool flag)
        {
            btnLuu.Enabled = btnHuy.Enabled = grbThongTin.Enabled = flag;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = dtgvHangHoa.Enabled = !flag;

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            showButton(true);
            txtMaSP.Enabled = true;
            lenh = ADD;

            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showButton(true);
            lenh = EDIT;
            txtMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    id_SanPham = Int32.Parse(txtID_SanPham.Text);
                    maSanPham = txtMaSP.Text;
                    tenSanPham = txtTenSP.Text;
                    giaSanPham = Int32.Parse(txtGiaSP.Text);
                    soLuongSP = Int32.Parse(txtSoLuong.Text);
                    SanPham_ET sanPham = new SanPham_ET(id_SanPham, maSanPham, tenSanPham, giaSanPham, soLuongSP);
                    if (bus_SanPham.DeleteSanPham(sanPham) == true)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            int dong = dtgvHangHoa.CurrentCell.RowIndex;

            txtID_SanPham.Text = dtgvHangHoa.Rows[dong].Cells[0].Value.ToString();
            txtMaSP.Text = dtgvHangHoa.Rows[dong].Cells[1].Value.ToString();
            txtTenSP.Text = dtgvHangHoa.Rows[dong].Cells[2].Value.ToString();
            txtGiaSP.Text = dtgvHangHoa.Rows[dong].Cells[3].Value.ToString();
            txtSoLuong.Text = dtgvHangHoa.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showButton(false);
            clearText();
        }

        private void clearText()
        {
            txtID_SanPham.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtSoLuong.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lenh == ADD)
            {
                try
                {
                    //id_SanPham = Int32.Parse(txtID_SanPham.Text);
                    maSanPham = txtMaSP.Text;
                    tenSanPham = txtTenSP.Text;
                    giaSanPham = Int32.Parse(txtGiaSP.Text);
                    soLuongSP = Int32.Parse(txtSoLuong.Text);
                    SanPham_ET sanPham = new SanPham_ET(maSanPham, tenSanPham, giaSanPham, soLuongSP);
                    if (bus_SanPham.AddSanPham(sanPham) == true)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (lenh == EDIT)
            {
                try
                {
                    id_SanPham = Int32.Parse(txtID_SanPham.Text);
                    maSanPham = txtMaSP.Text;
                    tenSanPham = txtTenSP.Text;
                    giaSanPham = Int32.Parse(txtGiaSP.Text);
                    soLuongSP = Int32.Parse(txtSoLuong.Text);
                    SanPham_ET sanPham = new SanPham_ET(id_SanPham, maSanPham, tenSanPham, giaSanPham, soLuongSP);
                    if (bus_SanPham.UpdateSanPham(sanPham) == true)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
