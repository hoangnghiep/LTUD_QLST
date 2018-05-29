namespace GUI_QLST
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvHangHoa = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frbThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblNhapTenSP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.grbThongTinBanHang = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txTong = new System.Windows.Forms.TextBox();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.lvBanHang = new System.Windows.Forms.ListView();
            this.colMaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSaPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblSoLuongMua = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).BeginInit();
            this.frbThongTinSanPham.SuspendLayout();
            this.grbThongTinNhanVien.SuspendLayout();
            this.grbThongTinBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHangHoa
            // 
            this.dtgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colGiaSP,
            this.colSoLuong});
            this.dtgvHangHoa.Location = new System.Drawing.Point(6, 53);
            this.dtgvHangHoa.Name = "dtgvHangHoa";
            this.dtgvHangHoa.Size = new System.Drawing.Size(413, 161);
            this.dtgvHangHoa.TabIndex = 14;
            this.dtgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangHoa_CellContentClick);
            // 
            // colMaSP
            // 
            this.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.Name = "colMaSP";
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            // 
            // colGiaSP
            // 
            this.colGiaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaSP.DataPropertyName = "GiaSP";
            this.colGiaSP.HeaderText = "Giá";
            this.colGiaSP.Name = "colGiaSP";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // frbThongTinSanPham
            // 
            this.frbThongTinSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frbThongTinSanPham.Controls.Add(this.btnTim);
            this.frbThongTinSanPham.Controls.Add(this.lblNhapTenSP);
            this.frbThongTinSanPham.Controls.Add(this.textBox1);
            this.frbThongTinSanPham.Controls.Add(this.dtgvHangHoa);
            this.frbThongTinSanPham.Location = new System.Drawing.Point(12, 207);
            this.frbThongTinSanPham.Name = "frbThongTinSanPham";
            this.frbThongTinSanPham.Size = new System.Drawing.Size(437, 231);
            this.frbThongTinSanPham.TabIndex = 6;
            this.frbThongTinSanPham.TabStop = false;
            this.frbThongTinSanPham.Text = "Danh sách sản phẩm";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(344, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lblNhapTenSP
            // 
            this.lblNhapTenSP.AutoSize = true;
            this.lblNhapTenSP.Location = new System.Drawing.Point(142, 24);
            this.lblNhapTenSP.Name = "lblNhapTenSP";
            this.lblNhapTenSP.Size = new System.Drawing.Size(75, 13);
            this.lblNhapTenSP.TabIndex = 7;
            this.lblNhapTenSP.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(232, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // grbThongTinNhanVien
            // 
            this.grbThongTinNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinNhanVien.Controls.Add(this.txtTenKhachHang);
            this.grbThongTinNhanVien.Controls.Add(this.lblTenKH);
            this.grbThongTinNhanVien.Controls.Add(this.txtTenNhanVien);
            this.grbThongTinNhanVien.Controls.Add(this.lblTenNV);
            this.grbThongTinNhanVien.Controls.Add(this.lblMaKH);
            this.grbThongTinNhanVien.Controls.Add(this.lblMaNV);
            this.grbThongTinNhanVien.Controls.Add(this.cboMaKhachHang);
            this.grbThongTinNhanVien.Controls.Add(this.cboMaNhanVien);
            this.grbThongTinNhanVien.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinNhanVien.Name = "grbThongTinNhanVien";
            this.grbThongTinNhanVien.Size = new System.Drawing.Size(437, 154);
            this.grbThongTinNhanVien.TabIndex = 7;
            this.grbThongTinNhanVien.TabStop = false;
            this.grbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(331, 84);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(246, 89);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(86, 13);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(331, 32);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(246, 37);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(15, 89);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(85, 13);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(15, 34);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(108, 83);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cboMaKhachHang.TabIndex = 3;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(108, 31);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cboMaNhanVien.TabIndex = 1;
            // 
            // grbThongTinBanHang
            // 
            this.grbThongTinBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinBanHang.Controls.Add(this.btnThanhToan);
            this.grbThongTinBanHang.Controls.Add(this.txTong);
            this.grbThongTinBanHang.Controls.Add(this.lblTongCong);
            this.grbThongTinBanHang.Controls.Add(this.lvBanHang);
            this.grbThongTinBanHang.Controls.Add(this.btnXoa);
            this.grbThongTinBanHang.Controls.Add(this.btnHuy);
            this.grbThongTinBanHang.Controls.Add(this.btnThem);
            this.grbThongTinBanHang.Controls.Add(this.txtSoLuongMua);
            this.grbThongTinBanHang.Controls.Add(this.txtTenSanPham);
            this.grbThongTinBanHang.Controls.Add(this.lblSoLuongMua);
            this.grbThongTinBanHang.Controls.Add(this.lblTenSP);
            this.grbThongTinBanHang.Location = new System.Drawing.Point(470, 12);
            this.grbThongTinBanHang.Name = "grbThongTinBanHang";
            this.grbThongTinBanHang.Size = new System.Drawing.Size(306, 426);
            this.grbThongTinBanHang.TabIndex = 8;
            this.grbThongTinBanHang.TabStop = false;
            this.grbThongTinBanHang.Text = "Thông tin bán hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Location = new System.Drawing.Point(208, 390);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txTong
            // 
            this.txTong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txTong.Location = new System.Drawing.Point(183, 357);
            this.txTong.Name = "txTong";
            this.txTong.Size = new System.Drawing.Size(100, 20);
            this.txTong.TabIndex = 12;
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(109, 364);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(59, 13);
            this.lblTongCong.TabIndex = 7;
            this.lblTongCong.Text = "Tổng cộng";
            // 
            // lvBanHang
            // 
            this.lvBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBanHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSanPham,
            this.colTenSaPham,
            this.colSoLuongMua});
            this.lvBanHang.GridLines = true;
            this.lvBanHang.Location = new System.Drawing.Point(22, 165);
            this.lvBanHang.Name = "lvBanHang";
            this.lvBanHang.Size = new System.Drawing.Size(261, 173);
            this.lvBanHang.TabIndex = 6;
            this.lvBanHang.UseCompatibleStateImageBehavior = false;
            this.lvBanHang.View = System.Windows.Forms.View.Details;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.Text = "Mã sản phẩm";
            this.colMaSanPham.Width = 78;
            // 
            // colTenSaPham
            // 
            this.colTenSaPham.Text = "Tên sản phẩm";
            this.colTenSaPham.Width = 100;
            // 
            // colSoLuongMua
            // 
            this.colSoLuongMua.Text = "Số lượng mua";
            this.colSoLuongMua.Width = 77;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(59, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(140, 115);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(221, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(128, 73);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(87, 20);
            this.txtSoLuongMua.TabIndex = 8;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(128, 34);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(155, 20);
            this.txtTenSanPham.TabIndex = 7;
            // 
            // lblSoLuongMua
            // 
            this.lblSoLuongMua.AutoSize = true;
            this.lblSoLuongMua.Location = new System.Drawing.Point(39, 73);
            this.lblSoLuongMua.Name = "lblSoLuongMua";
            this.lblSoLuongMua.Size = new System.Drawing.Size(72, 13);
            this.lblSoLuongMua.TabIndex = 1;
            this.lblSoLuongMua.Text = "Sô lượng mua";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(36, 37);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(75, 13);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbThongTinBanHang);
            this.Controls.Add(this.grbThongTinNhanVien);
            this.Controls.Add(this.frbThongTinSanPham);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).EndInit();
            this.frbThongTinSanPham.ResumeLayout(false);
            this.frbThongTinSanPham.PerformLayout();
            this.grbThongTinNhanVien.ResumeLayout(false);
            this.grbThongTinNhanVien.PerformLayout();
            this.grbThongTinBanHang.ResumeLayout(false);
            this.grbThongTinBanHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.GroupBox frbThongTinSanPham;
        private System.Windows.Forms.GroupBox grbThongTinNhanVien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.GroupBox grbThongTinBanHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txTong;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.ListView lvBanHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblSoLuongMua;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.ColumnHeader colMaSanPham;
        private System.Windows.Forms.ColumnHeader colTenSaPham;
        private System.Windows.Forms.ColumnHeader colSoLuongMua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblNhapTenSP;
        private System.Windows.Forms.TextBox textBox1;
    }
}