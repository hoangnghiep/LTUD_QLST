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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        //Khai báo bus nhân viên
        NhanVien_BUS bus_NhanVien = new NhanVien_BUS();
        string lenh;
        string ADD = "add";
        string EDIT = "edit";

        //Khai báo các biến
        private int id_NhanVien;
        private string hoTenNV;
        private string gioiTinh;
        private string diaChi;
        private string sdt;
        private DateTime ngaySinh;

        //Hàm enable các butuon
        public void showButton(bool flag)
        {
            btnLuu.Enabled = btnHuy.Enabled = grbThongTin.Enabled = flag;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = dtgvNhanVien.Enabled = !flag;

        }

        //Hàm xóa các textbox
        private void clearText()
        {
            txtID_NhanVien.Clear();
            txtTenNV.Clear();
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
            dtpNgaySinh.Value = DateTime.Now;
        }

        //Load dữ liệu ngay khi chạy form
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = bus_NhanVien.GetAllNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            showButton(true);//xử lý các nút
            lenh = ADD;//gửi lệnh thêm

            clearText();//và xóa các textbox
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showButton(true);
            lenh = EDIT;//gửi lệnh sửa
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Dialog xác nhận xóa hay ko
            DialogResult res = MessageBox.Show("Bạn có muốn xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    id_NhanVien = Int32.Parse(txtID_NhanVien.Text);
                    hoTenNV = txtTenNV.Text;
                    //kiểm tra radio button
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
                    ngaySinh = dtpNgaySinh.Value;//get ngày sinh

                    NhanVien_ET nhanVien = new NhanVien_ET(id_NhanVien, hoTenNV, gioiTinh, diaChi, sdt, ngaySinh);
                    if (bus_NhanVien.DeleteNhanVien(nhanVien) == true)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvNhanVien.DataSource = bus_NhanVien.GetAllNhanVien();
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
            if (lenh == ADD)
            {
                try
                {
                    // id_NhanVien = Int32.Parse(txtID_NhanVien.Text);
                    hoTenNV = txtTenNV.Text;
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
                    ngaySinh = dtpNgaySinh.Value;

                    NhanVien_ET nhanVien = new NhanVien_ET(hoTenNV, gioiTinh, diaChi, sdt, ngaySinh);
                    if (bus_NhanVien.AddNhanVien(nhanVien) == true)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvNhanVien.DataSource = bus_NhanVien.GetAllNhanVien();
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
                    id_NhanVien = Int32.Parse(txtID_NhanVien.Text);
                    hoTenNV = txtTenNV.Text;
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
                    ngaySinh = dtpNgaySinh.Value;

                    NhanVien_ET nhanVien = new NhanVien_ET(id_NhanVien, hoTenNV, gioiTinh, diaChi, sdt, ngaySinh);
                    if (bus_NhanVien.UpdateNhanVien(nhanVien) == true)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showButton(false);
                        clearText();
                        dtgvNhanVien.DataSource = bus_NhanVien.GetAllNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            int dong = dtgvNhanVien.CurrentCell.RowIndex;

            txtID_NhanVien.Text = dtgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtTenNV.Text = dtgvNhanVien.Rows[dong].Cells[1].Value.ToString();

            if (dtgvNhanVien.Rows[dong].Cells[2].Value.ToString() == "Nam")
            {
                rabNam.Checked = true;
            }
            if (dtgvNhanVien.Rows[dong].Cells[2].Value.ToString() == "Nữ")
            {
                rabNu.Checked = true;
            }

            txtDiaChi.Text = dtgvNhanVien.Rows[dong].Cells[3].Value.ToString();
            txtSDT.Text = dtgvNhanVien.Rows[dong].Cells[4].Value.ToString();
            //string ngaysinh = dtgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            //dtpNgaySinh.Value = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy h:m:s", null);
            dtpNgaySinh.Value = DateTime.Parse(dtgvNhanVien.Rows[dong].Cells[5].Value.ToString());
        }
    }
}
