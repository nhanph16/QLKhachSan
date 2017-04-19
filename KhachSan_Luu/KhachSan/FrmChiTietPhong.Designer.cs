namespace KhachSan
{
    partial class FrmChiTietPhong
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
            this.btUpd = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtLoaiHinhThue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dtgChi = new System.Windows.Forms.DataGridView();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.dtNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.dtNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChi)).BeginInit();
            this.SuspendLayout();
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(408, 452);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(87, 44);
            this.btUpd.TabIndex = 10;
            this.btUpd.Text = "Sửa thông tin";
            this.btUpd.UseVisualStyleBackColor = true;
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(524, 452);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(86, 44);
            this.btIn.TabIndex = 11;
            this.btIn.Text = "In hóa đơn";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(284, 452);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(97, 44);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Đặt phòng";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 113);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(276, 86);
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtLoaiHinhThue
            // 
            this.txtLoaiHinhThue.Location = new System.Drawing.Point(641, 87);
            this.txtLoaiHinhThue.Name = "txtLoaiHinhThue";
            this.txtLoaiHinhThue.Size = new System.Drawing.Size(276, 20);
            this.txtLoaiHinhThue.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Loại hình thuê";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(103, 9);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(276, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày trả phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày đặt phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày nhận phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(641, 113);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(276, 20);
            this.txtThanhTien.TabIndex = 7;
            // 
            // dtgChi
            // 
            this.dtgChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgChi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChi.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dtgChi.Location = new System.Drawing.Point(2, 210);
            this.dtgChi.Name = "dtgChi";
            this.dtgChi.Size = new System.Drawing.Size(925, 236);
            this.dtgChi.TabIndex = 12;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(103, 35);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(276, 21);
            this.cbbMaKH.TabIndex = 38;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(103, 61);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(276, 21);
            this.cbbMaPhong.TabIndex = 38;
            // 
            // dtNgayDatPhong
            // 
            this.dtNgayDatPhong.CustomFormat = "dd/MM/yyyy - H:mm:ss";
            this.dtNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDatPhong.Location = new System.Drawing.Point(103, 88);
            this.dtNgayDatPhong.Name = "dtNgayDatPhong";
            this.dtNgayDatPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayDatPhong.TabIndex = 39;
            // 
            // dtNgayNhanPhong
            // 
            this.dtNgayNhanPhong.CustomFormat = "dd/MM/yyyy - H:mm:ss";
            this.dtNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhanPhong.Location = new System.Drawing.Point(641, 36);
            this.dtNgayNhanPhong.Name = "dtNgayNhanPhong";
            this.dtNgayNhanPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayNhanPhong.TabIndex = 39;
            // 
            // dtNgayTraPhong
            // 
            this.dtNgayTraPhong.CustomFormat = "dd/MM/yyyy - H:mm:ss";
            this.dtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTraPhong.Location = new System.Drawing.Point(641, 62);
            this.dtNgayTraPhong.Name = "dtNgayTraPhong";
            this.dtNgayTraPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayTraPhong.TabIndex = 39;
            // 
            // FrmChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 507);
            this.Controls.Add(this.dtNgayTraPhong);
            this.Controls.Add(this.dtNgayNhanPhong);
            this.Controls.Add(this.dtNgayDatPhong);
            this.Controls.Add(this.cbbMaPhong);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.dtgChi);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtLoaiHinhThue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietPhong";
            this.Load += new System.EventHandler(this.FrmChiTietPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtLoaiHinhThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridView dtgChi;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.DateTimePicker dtNgayDatPhong;
        private System.Windows.Forms.DateTimePicker dtNgayNhanPhong;
        private System.Windows.Forms.DateTimePicker dtNgayTraPhong;
    }
}