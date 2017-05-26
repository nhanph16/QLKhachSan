namespace KhachSan
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNhânViên = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChiTietPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWelcome = new System.Windows.Forms.ToolStripTextBox();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhSachTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.rdDaDat = new System.Windows.Forms.RadioButton();
            this.rdChuaDat = new System.Windows.Forms.RadioButton();
            this.pnButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhânViên,
            this.menuThongKe,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNhânViên
            // 
            this.menuNhânViên.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.menuDangXuat,
            this.menuThoat});
            this.menuNhânViên.Name = "menuNhânViên";
            this.menuNhânViên.Size = new System.Drawing.Size(46, 20);
            this.menuNhânViên.Text = "Main";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuKhachHang,
            this.menuChiTietPhong,
            this.menuPhong});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Quản lý";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(153, 22);
            this.menuNhanVien.Text = "Nhân Viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(153, 22);
            this.menuKhachHang.Text = "Khách Hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuChiTietPhong
            // 
            this.menuChiTietPhong.Name = "menuChiTietPhong";
            this.menuChiTietPhong.Size = new System.Drawing.Size(153, 22);
            this.menuChiTietPhong.Text = "Chi Tiết Phòng";
            this.menuChiTietPhong.Click += new System.EventHandler(this.menuChiTietPhong_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(152, 22);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(152, 22);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(69, 20);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtWelcome,
            this.menuDoiMatKhau,
            this.menuDanhSachTaiKhoan});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.Color.White;
            this.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcome.Enabled = false;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(100, 16);
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(178, 22);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);
            // 
            // menuDanhSachTaiKhoan
            // 
            this.menuDanhSachTaiKhoan.Name = "menuDanhSachTaiKhoan";
            this.menuDanhSachTaiKhoan.Size = new System.Drawing.Size(178, 22);
            this.menuDanhSachTaiKhoan.Text = "Thông tin tài khoản";
            this.menuDanhSachTaiKhoan.Click += new System.EventHandler(this.menuDanhSachTaiKhoan_Click);
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Location = new System.Drawing.Point(22, 303);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(56, 17);
            this.rdTatCa.TabIndex = 2;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.UseVisualStyleBackColor = true;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.rdTatCa_CheckedChanged);
            // 
            // rdDaDat
            // 
            this.rdDaDat.AutoSize = true;
            this.rdDaDat.Location = new System.Drawing.Point(84, 303);
            this.rdDaDat.Name = "rdDaDat";
            this.rdDaDat.Size = new System.Drawing.Size(91, 17);
            this.rdDaDat.TabIndex = 2;
            this.rdDaDat.TabStop = true;
            this.rdDaDat.Text = "Phòng đã đặt";
            this.rdDaDat.UseVisualStyleBackColor = true;
            this.rdDaDat.CheckedChanged += new System.EventHandler(this.rdDaDat_CheckedChanged);
            // 
            // rdChuaDat
            // 
            this.rdChuaDat.AutoSize = true;
            this.rdChuaDat.Location = new System.Drawing.Point(181, 303);
            this.rdChuaDat.Name = "rdChuaDat";
            this.rdChuaDat.Size = new System.Drawing.Size(83, 17);
            this.rdChuaDat.TabIndex = 2;
            this.rdChuaDat.TabStop = true;
            this.rdChuaDat.Text = "Phòng trống";
            this.rdChuaDat.UseVisualStyleBackColor = true;
            this.rdChuaDat.CheckedChanged += new System.EventHandler(this.rdChuaDat_CheckedChanged);
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnButton.Location = new System.Drawing.Point(12, 326);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1330, 351);
            this.pnButton.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trống";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1081, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 28);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1171, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đã đặt";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1161, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 28);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1370, 113);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khách sạn con nai vàng ngơ ngác";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPhong
            // 
            this.menuPhong.Name = "menuPhong";
            this.menuPhong.Size = new System.Drawing.Size(153, 22);
            this.menuPhong.Text = "Phòng";
            this.menuPhong.Click += new System.EventHandler(this.menuPhong_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.rdChuaDat);
            this.Controls.Add(this.rdDaDat);
            this.Controls.Add(this.rdTatCa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNhânViên;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtWelcome;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuDanhSachTaiKhoan;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.RadioButton rdDaDat;
        private System.Windows.Forms.RadioButton rdChuaDat;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menuChiTietPhong;
        private System.Windows.Forms.ToolStripMenuItem menuPhong;
    }
}