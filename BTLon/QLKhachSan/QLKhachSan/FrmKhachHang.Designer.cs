namespace QLKhachSan
{
    partial class FrmKhachHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdMaKH = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.dgvTimKiemKH = new System.Windows.Forms.DataGridView();
            this.btTimKiemKH = new System.Windows.Forms.Button();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btReset = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvThemKH = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtHoKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.dgvXoaKH = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rpvKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemKH)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaKH)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.rdMaKH);
            this.tabPage1.Controls.Add(this.rdTen);
            this.tabPage1.Controls.Add(this.dgvTimKiemKH);
            this.tabPage1.Controls.Add(this.btTimKiemKH);
            this.tabPage1.Controls.Add(this.txtTimKiemKH);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm Kiếm";
            // 
            // rdMaKH
            // 
            this.rdMaKH.AutoSize = true;
            this.rdMaKH.Checked = true;
            this.rdMaKH.Location = new System.Drawing.Point(262, 69);
            this.rdMaKH.Name = "rdMaKH";
            this.rdMaKH.Size = new System.Drawing.Size(51, 24);
            this.rdMaKH.TabIndex = 4;
            this.rdMaKH.TabStop = true;
            this.rdMaKH.Text = "Mã";
            this.rdMaKH.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(401, 69);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(57, 24);
            this.rdTen.TabIndex = 4;
            this.rdTen.Text = "Tên";
            this.rdTen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // dgvTimKiemKH
            // 
            this.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemKH.Location = new System.Drawing.Point(6, 99);
            this.dgvTimKiemKH.Name = "dgvTimKiemKH";
            this.dgvTimKiemKH.Size = new System.Drawing.Size(795, 338);
            this.dgvTimKiemKH.TabIndex = 3;
            // 
            // btTimKiemKH
            // 
            this.btTimKiemKH.BackgroundImage = global::QLKhachSan.Properties.Resources.timkiem;
            this.btTimKiemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiemKH.Location = new System.Drawing.Point(562, 23);
            this.btTimKiemKH.Name = "btTimKiemKH";
            this.btTimKiemKH.Size = new System.Drawing.Size(42, 26);
            this.btTimKiemKH.TabIndex = 2;
            this.btTimKiemKH.UseVisualStyleBackColor = true;
            this.btTimKiemKH.Click += new System.EventHandler(this.btTimKiemKH_Click);
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(239, 23);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(299, 26);
            this.txtTimKiemKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btReset);
            this.tabPage2.Controls.Add(this.dtpNgaySinh);
            this.tabPage2.Controls.Add(this.dgvThemKH);
            this.tabPage2.Controls.Add(this.txtDiaChi);
            this.tabPage2.Controls.Add(this.txtSDT);
            this.tabPage2.Controls.Add(this.txtCMND);
            this.tabPage2.Controls.Add(this.txtTenKH);
            this.tabPage2.Controls.Add(this.txtHoKH);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtMaKH);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btSua);
            this.tabPage2.Controls.Add(this.btThem);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm và sửa";
            // 
            // btReset
            // 
            this.btReset.BackgroundImage = global::QLKhachSan.Properties.Resources.trolai;
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReset.Location = new System.Drawing.Point(716, 50);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(70, 60);
            this.btReset.TabIndex = 5;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(424, 12);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(142, 26);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // dgvThemKH
            // 
            this.dgvThemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemKH.Location = new System.Drawing.Point(0, 150);
            this.dgvThemKH.Name = "dgvThemKH";
            this.dgvThemKH.Size = new System.Drawing.Size(801, 290);
            this.dgvThemKH.TabIndex = 2;
            this.dgvThemKH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemKH_RowEnter);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(104, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 26);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(424, 87);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(142, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(424, 50);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(142, 26);
            this.txtCMND.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(106, 87);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(95, 26);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtHoKH
            // 
            this.txtHoKH.Location = new System.Drawing.Point(106, 50);
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.Size = new System.Drawing.Size(175, 26);
            this.txtHoKH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(106, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(95, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // btSua
            // 
            this.btSua.BackgroundImage = global::QLKhachSan.Properties.Resources.suanv;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSua.Location = new System.Drawing.Point(621, 82);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(79, 63);
            this.btSua.TabIndex = 3;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = global::QLKhachSan.Properties.Resources.themnv1;
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThem.Location = new System.Drawing.Point(621, 13);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(79, 63);
            this.btThem.TabIndex = 3;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.cbbMaKH);
            this.tabPage3.Controls.Add(this.dgvXoaKH);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btXoa);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(801, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xóa";
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(227, 18);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(152, 28);
            this.cbbMaKH.TabIndex = 4;
            // 
            // dgvXoaKH
            // 
            this.dgvXoaKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaKH.Location = new System.Drawing.Point(3, 66);
            this.dgvXoaKH.Name = "dgvXoaKH";
            this.dgvXoaKH.Size = new System.Drawing.Size(798, 371);
            this.dgvXoaKH.TabIndex = 3;
            this.dgvXoaKH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXoaKH_RowEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã KH:";
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = global::QLKhachSan.Properties.Resources.xoanv;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoa.Location = new System.Drawing.Point(399, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(78, 57);
            this.btXoa.TabIndex = 0;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rpvKhachHang);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(801, 440);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rpvKhachHang
            // 
            this.rpvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.rpvKhachHang.Name = "rpvKhachHang";
            this.rpvKhachHang.Size = new System.Drawing.Size(801, 440);
            this.rpvKhachHang.TabIndex = 0;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 470);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemKH)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaKH)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdMaKH;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.DataGridView dgvTimKiemKH;
        private System.Windows.Forms.Button btTimKiemKH;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvThemKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtHoKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.DataGridView dgvXoaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKhachHang;
    }
}