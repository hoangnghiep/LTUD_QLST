namespace GUI_QLST
{
    partial class frmMain
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
            this.mestripMain = new System.Windows.Forms.MenuStrip();
            this.toolQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mestripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mestripMain
            // 
            this.mestripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolQuanLy,
            this.toolThongTin,
            this.toolHuongDan});
            this.mestripMain.Location = new System.Drawing.Point(0, 0);
            this.mestripMain.Name = "mestripMain";
            this.mestripMain.Size = new System.Drawing.Size(617, 24);
            this.mestripMain.TabIndex = 0;
            this.mestripMain.Text = "menuStrip1";
            // 
            // toolQuanLy
            // 
            this.toolQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNhanVien,
            this.toolKhachHang,
            this.toolHangHoa,
            this.toolHoaDon});
            this.toolQuanLy.Name = "toolQuanLy";
            this.toolQuanLy.Size = new System.Drawing.Size(62, 20);
            this.toolQuanLy.Text = "Quản Lý";
            // 
            // toolNhanVien
            // 
            this.toolNhanVien.Name = "toolNhanVien";
            this.toolNhanVien.Size = new System.Drawing.Size(180, 22);
            this.toolNhanVien.Text = "Nhân Viên";
            this.toolNhanVien.Click += new System.EventHandler(this.toolNhanVien_Click);
            // 
            // toolKhachHang
            // 
            this.toolKhachHang.Name = "toolKhachHang";
            this.toolKhachHang.Size = new System.Drawing.Size(180, 22);
            this.toolKhachHang.Text = "Khách Hàng";
            this.toolKhachHang.Click += new System.EventHandler(this.toolKhachHang_Click);
            // 
            // toolHangHoa
            // 
            this.toolHangHoa.Name = "toolHangHoa";
            this.toolHangHoa.Size = new System.Drawing.Size(180, 22);
            this.toolHangHoa.Text = "Hàng Hóa";
            this.toolHangHoa.Click += new System.EventHandler(this.toolHangHoa_Click);
            // 
            // toolHoaDon
            // 
            this.toolHoaDon.Name = "toolHoaDon";
            this.toolHoaDon.Size = new System.Drawing.Size(180, 22);
            this.toolHoaDon.Text = "Hóa Đơn";
            this.toolHoaDon.Click += new System.EventHandler(this.toolHoaDon_Click);
            // 
            // toolThongTin
            // 
            this.toolThongTin.Name = "toolThongTin";
            this.toolThongTin.Size = new System.Drawing.Size(74, 20);
            this.toolThongTin.Text = "Thông Tin";
            // 
            // toolHuongDan
            // 
            this.toolHuongDan.Name = "toolHuongDan";
            this.toolHuongDan.Size = new System.Drawing.Size(128, 20);
            this.toolHuongDan.Text = "Hướng Dẫn Sử Dụng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 345);
            this.Controls.Add(this.mestripMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý siêu thị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mestripMain.ResumeLayout(false);
            this.mestripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mestripMain;
        private System.Windows.Forms.ToolStripMenuItem toolQuanLy;
        private System.Windows.Forms.ToolStripMenuItem toolNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolHangHoa;
        private System.Windows.Forms.ToolStripMenuItem toolHoaDon;
        private System.Windows.Forms.ToolStripMenuItem toolThongTin;
        private System.Windows.Forms.ToolStripMenuItem toolHuongDan;
    }
}

