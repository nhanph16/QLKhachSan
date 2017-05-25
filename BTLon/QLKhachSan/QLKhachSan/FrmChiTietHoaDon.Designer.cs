namespace QLKhachSan
{
    partial class FrmChiTietHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btThemSP = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btXoaSP = new System.Windows.Forms.Button();
            this.btReSetSP = new System.Windows.Forms.Button();
            this.btSuaSP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.cbbMaHD = new System.Windows.Forms.ComboBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvSanPhamHT = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btXoaCTHD = new System.Windows.Forms.Button();
            this.btResetCT = new System.Windows.Forms.Button();
            this.btSuaCTHD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbCTHoaDon = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbReportHoaDon = new System.Windows.Forms.ComboBox();
            this.rdSanPham = new System.Windows.Forms.RadioButton();
            this.rdCTHoaDon = new System.Windows.Forms.RadioButton();
            this.rpvSanPham = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamHT)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(553, 38);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(124, 24);
            this.txtMaSP.TabIndex = 1;
            // 
            // btThemSP
            // 
            this.btThemSP.BackgroundImage = global::QLKhachSan.Properties.Resources.them;
            this.btThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSP.Location = new System.Drawing.Point(479, 234);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(86, 77);
            this.btThemSP.TabIndex = 2;
            this.btThemSP.UseVisualStyleBackColor = true;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(436, 497);
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_RowEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 524);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.txtGia);
            this.tabPage1.Controls.Add(this.txtSLTon);
            this.tabPage1.Controls.Add(this.txtTenSP);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMaSP);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvSanPham);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btXoaSP);
            this.tabPage1.Controls.Add(this.btReSetSP);
            this.tabPage1.Controls.Add(this.btSuaSP);
            this.tabPage1.Controls.Add(this.btThemSP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản Phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(553, 169);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(124, 24);
            this.txtGia.TabIndex = 1;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(553, 127);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(124, 24);
            this.txtSLTon.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(553, 82);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(124, 24);
            this.txtTenSP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SL Tồn Kho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SP:";
            // 
            // btXoaSP
            // 
            this.btXoaSP.BackgroundImage = global::QLKhachSan.Properties.Resources.xoanv1;
            this.btXoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaSP.Location = new System.Drawing.Point(611, 343);
            this.btXoaSP.Name = "btXoaSP";
            this.btXoaSP.Size = new System.Drawing.Size(86, 77);
            this.btXoaSP.TabIndex = 2;
            this.btXoaSP.UseVisualStyleBackColor = true;
            this.btXoaSP.Click += new System.EventHandler(this.btXoaSP_Click);
            // 
            // btReSetSP
            // 
            this.btReSetSP.BackgroundImage = global::QLKhachSan.Properties.Resources.trolai;
            this.btReSetSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReSetSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReSetSP.Location = new System.Drawing.Point(479, 343);
            this.btReSetSP.Name = "btReSetSP";
            this.btReSetSP.Size = new System.Drawing.Size(86, 77);
            this.btReSetSP.TabIndex = 2;
            this.btReSetSP.UseVisualStyleBackColor = true;
            this.btReSetSP.Click += new System.EventHandler(this.btReSetSP_Click);
            // 
            // btSuaSP
            // 
            this.btSuaSP.BackgroundImage = global::QLKhachSan.Properties.Resources.sua;
            this.btSuaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaSP.Location = new System.Drawing.Point(611, 234);
            this.btSuaSP.Name = "btSuaSP";
            this.btSuaSP.Size = new System.Drawing.Size(86, 77);
            this.btSuaSP.TabIndex = 2;
            this.btSuaSP.UseVisualStyleBackColor = true;
            this.btSuaSP.Click += new System.EventHandler(this.btSuaSP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.cbbMaSP);
            this.tabPage2.Controls.Add(this.cbbMaHD);
            this.tabPage2.Controls.Add(this.dgvChiTietHoaDon);
            this.tabPage2.Controls.Add(this.dgvSanPhamHT);
            this.tabPage2.Controls.Add(this.txtThanhTien);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDonGia);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSoLuong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btXoaCTHD);
            this.tabPage2.Controls.Add(this.btResetCT);
            this.tabPage2.Controls.Add(this.btSuaCTHD);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Hóa Đơn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(374, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(109, 69);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(121, 26);
            this.cbbMaSP.TabIndex = 5;
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(109, 27);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(121, 26);
            this.cbbMaHD.TabIndex = 4;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(3, 225);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(786, 268);
            this.dgvChiTietHoaDon.TabIndex = 3;
            this.dgvChiTietHoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_RowEnter);
            // 
            // dgvSanPhamHT
            // 
            this.dgvSanPhamHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamHT.Location = new System.Drawing.Point(419, 0);
            this.dgvSanPhamHT.Name = "dgvSanPhamHT";
            this.dgvSanPhamHT.Size = new System.Drawing.Size(366, 227);
            this.dgvSanPhamHT.TabIndex = 3;
            this.dgvSanPhamHT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhamHT_RowEnter);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(110, 195);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(112, 24);
            this.txtThanhTien.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thành Tiền:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(110, 150);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(112, 24);
            this.txtDonGia.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đơn Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(110, 110);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(86, 24);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã Sản Phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Hóa Đơn:";
            // 
            // btXoaCTHD
            // 
            this.btXoaCTHD.BackgroundImage = global::QLKhachSan.Properties.Resources.xoanv;
            this.btXoaCTHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaCTHD.Location = new System.Drawing.Point(342, 131);
            this.btXoaCTHD.Name = "btXoaCTHD";
            this.btXoaCTHD.Size = new System.Drawing.Size(71, 63);
            this.btXoaCTHD.TabIndex = 0;
            this.btXoaCTHD.UseVisualStyleBackColor = true;
            this.btXoaCTHD.Click += new System.EventHandler(this.btXoaCTHD_Click);
            // 
            // btResetCT
            // 
            this.btResetCT.BackgroundImage = global::QLKhachSan.Properties.Resources.trolai;
            this.btResetCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btResetCT.Location = new System.Drawing.Point(246, 131);
            this.btResetCT.Name = "btResetCT";
            this.btResetCT.Size = new System.Drawing.Size(71, 63);
            this.btResetCT.TabIndex = 0;
            this.btResetCT.UseVisualStyleBackColor = true;
            this.btResetCT.Click += new System.EventHandler(this.btResetCT_Click);
            // 
            // btSuaCTHD
            // 
            this.btSuaCTHD.BackgroundImage = global::QLKhachSan.Properties.Resources.sua;
            this.btSuaCTHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaCTHD.Location = new System.Drawing.Point(342, 27);
            this.btSuaCTHD.Name = "btSuaCTHD";
            this.btSuaCTHD.Size = new System.Drawing.Size(71, 63);
            this.btSuaCTHD.TabIndex = 0;
            this.btSuaCTHD.UseVisualStyleBackColor = true;
            this.btSuaCTHD.Click += new System.EventHandler(this.btSuaCTHD_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::QLKhachSan.Properties.Resources.them;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(246, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 63);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.cbCTHoaDon);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.cbbReportHoaDon);
            this.tabPage3.Controls.Add(this.rdSanPham);
            this.tabPage3.Controls.Add(this.rdCTHoaDon);
            this.tabPage3.Controls.Add(this.rpvSanPham);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(785, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report";
            // 
            // cbCTHoaDon
            // 
            this.cbCTHoaDon.AutoSize = true;
            this.cbCTHoaDon.Location = new System.Drawing.Point(127, 53);
            this.cbCTHoaDon.Name = "cbCTHoaDon";
            this.cbCTHoaDon.Size = new System.Drawing.Size(15, 14);
            this.cbCTHoaDon.TabIndex = 4;
            this.cbCTHoaDon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QLKhachSan.Properties.Resources.Print;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(441, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 78);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbReportHoaDon
            // 
            this.cbbReportHoaDon.FormattingEnabled = true;
            this.cbbReportHoaDon.Location = new System.Drawing.Point(127, 72);
            this.cbbReportHoaDon.Name = "cbbReportHoaDon";
            this.cbbReportHoaDon.Size = new System.Drawing.Size(177, 26);
            this.cbbReportHoaDon.TabIndex = 2;
            // 
            // rdSanPham
            // 
            this.rdSanPham.AutoSize = true;
            this.rdSanPham.Location = new System.Drawing.Point(322, 27);
            this.rdSanPham.Name = "rdSanPham";
            this.rdSanPham.Size = new System.Drawing.Size(95, 22);
            this.rdSanPham.TabIndex = 1;
            this.rdSanPham.Text = "Sản Phẩm";
            this.rdSanPham.UseVisualStyleBackColor = true;
            // 
            // rdCTHoaDon
            // 
            this.rdCTHoaDon.AutoSize = true;
            this.rdCTHoaDon.Checked = true;
            this.rdCTHoaDon.Location = new System.Drawing.Point(127, 27);
            this.rdCTHoaDon.Name = "rdCTHoaDon";
            this.rdCTHoaDon.Size = new System.Drawing.Size(128, 22);
            this.rdCTHoaDon.TabIndex = 1;
            this.rdCTHoaDon.TabStop = true;
            this.rdCTHoaDon.Text = "ChiTietHoaDon";
            this.rdCTHoaDon.UseVisualStyleBackColor = true;
            // 
            // rpvSanPham
            // 
            this.rpvSanPham.Location = new System.Drawing.Point(3, 104);
            this.rpvSanPham.Name = "rpvSanPham";
            this.rpvSanPham.Size = new System.Drawing.Size(782, 393);
            this.rpvSanPham.TabIndex = 0;
            // 
            // FrmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmChiTietHoaDon";
            this.Text = "FrmChiTietHoaDon";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamHT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXoaSP;
        private System.Windows.Forms.Button btReSetSP;
        private System.Windows.Forms.Button btSuaSP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridView dgvSanPhamHT;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private System.Windows.Forms.Button btXoaCTHD;
        private System.Windows.Forms.Button btResetCT;
        private System.Windows.Forms.Button btSuaCTHD;
        private System.Windows.Forms.CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSanPham;
        private System.Windows.Forms.ComboBox cbbReportHoaDon;
        private System.Windows.Forms.RadioButton rdSanPham;
        private System.Windows.Forms.RadioButton rdCTHoaDon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbCTHoaDon;
    }
}