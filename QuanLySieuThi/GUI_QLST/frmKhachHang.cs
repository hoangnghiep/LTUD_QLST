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
using BUS;

namespace GUI_QLST
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KhachHang_BUS bus_KhachHang = new KhachHang_BUS();
        string lenh;
        string ADD = "add";
        string EDIT = "edit";

        private int id_KhachHang;
        private string hoTenNV;
        private string gioiTinh;
        private string diaChi;
        private string sdt;

        public void showButton(bool flag)
        {
            btnLuu.Enabled = btnHuy.Enabled = grbThongTin.Enabled = flag;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = dtgvKhachHang.Enabled = !flag;

        }

        private void clearText()
        {
            txtID_KhachHang.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            if (rabNam.Checked)
            {
                rabNam.Checked = false;
            }
            if (rabNu.Checked)
            {
                rabNu.Checked = false;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = bus_KhachHang.GetAllKhachHang();
        }

        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            int dong = dtgvKhachHang.CurrentCell.RowIndex;

            txtID_KhachHang.Text = dtgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            txtTenKH.Text = dtgvKhachHang.Rows[dong].Cells[1].Value.ToString();

            if (dtgvKhachHang.Rows[dong].Cells[2].Value.ToString() == "Nam")
            {
                rabNam.Checked = true;
            }
            if (dtgvKhachHang.Rows[dong].Cells[2].Value.ToString() == "Nữ")
            {
                rabNu.Checked = true;
            }

            txtDiaChi.Text = dtgvKhachHang.Rows[dong].Cells[3].Value.ToString();
            txtSDT.Text = dtgvKhachHang.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            showButton(true);
            lenh = ADD;

            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showButton(true);
            lenh = EDIT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    id_KhachHang = Int32.Parse(txtID_KhachHang.Text);
                    hoTenNV = txtTenKH.Text;
                    if (rabNam.Checked)
                    {
                        gioiTinh = "Nam";
                    }
                    if (rabNu.Checked)
                    {
                        gioiTinh = "Nữ";
                    }
                    diaChi = txtDiaChi.Text;
                    sdt = txtSDT.Text;

                    KhachHang_ET khachHang = new KhachHang_ET(id_KhachHang, hoTenNV, gioiTinh, diaChi, sdt);
                    if (bus_KhachHang.DeleteKhachHang(khachHang) == true)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvKhachHang.DataSource = bus_KhachHang.GetAllKhachHang();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(lenh == ADD)
            {
                try
                {
                    //id_KhachHang = Int32.Parse(txtID_KhachHang.Text);
                    hoTenNV = txtTenKH.Text;
                    if (rabNam.Checked)
                    {
                        gioiTinh = "Nam";
                    }
                    if (rabNu.Checked)
                    {
                        gioiTinh = "Nữ";
                    }
                    diaChi = txtDiaChi.Text;
                    sdt = txtSDT.Text;

                    KhachHang_ET khachHang = new KhachHang_ET(hoTenNV, gioiTinh, diaChi, sdt);
                    if (bus_KhachHang.AddKhachHang(khachHang) == true)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvKhachHang.DataSource = bus_KhachHang.GetAllKhachHang();
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

            if(lenh == EDIT)
            {
                try
                {
                    id_KhachHang = Int32.Parse(txtID_KhachHang.Text);
                    hoTenNV = txtTenKH.Text;
                    if (rabNam.Checked)
                    {
                        gioiTinh = "Nam";
                    }
                    if (rabNu.Checked)
                    {
                        gioiTinh = "Nữ";
                    }
                    diaChi = txtDiaChi.Text;
                    sdt = txtSDT.Text;

                    KhachHang_ET khachHang = new KhachHang_ET(id_KhachHang, hoTenNV, gioiTinh, diaChi, sdt);
                    if (bus_KhachHang.UpdateKhachHang(khachHang) == true)
                    {
                        MessageBox.Show("Sửa khách hàng thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvKhachHang.DataSource = bus_KhachHang.GetAllKhachHang();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showButton(false);
            clearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
