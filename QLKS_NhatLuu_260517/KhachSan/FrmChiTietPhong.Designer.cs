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
            this.components = new System.ComponentModel.Container();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSanDataSet = new KhachSan.QLKhachSanDataSet();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.dtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.dtNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.dtgChi = new System.Windows.Forms.DataGridView();
            this.btUpd = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangTableAdapter = new KhachSan.QLKhachSanDataSetTableAdapters.KhachHangTableAdapter();
            this.phongTableAdapter = new KhachSan.QLKhachSanDataSetTableAdapters.PhongTableAdapter();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtLoaiHinhThue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(631, 114);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(276, 20);
            this.txtThanhTien.TabIndex = 66;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.DataSource = this.phongBindingSource;
            this.cbbMaPhong.DisplayMember = "MaPhong";
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(93, 62);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(276, 21);
            this.cbbMaPhong.TabIndex = 65;
            this.cbbMaPhong.ValueMember = "MaPhong";
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.qLKhachSanDataSet;
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DataSource = this.khachHangBindingSource;
            this.cbbMaKH.DisplayMember = "MaKH";
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(93, 35);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(276, 21);
            this.cbbMaKH.TabIndex = 64;
            this.cbbMaKH.ValueMember = "HoKH";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qLKhachSanDataSet;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Location = new System.Drawing.Point(631, 140);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(15, 14);
            this.cbTrangThai.TabIndex = 63;
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // dtNgayTraPhong
            // 
            this.dtNgayTraPhong.CustomFormat = "yyyy/MM/dd";
            this.dtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTraPhong.Location = new System.Drawing.Point(631, 63);
            this.dtNgayTraPhong.Name = "dtNgayTraPhong";
            this.dtNgayTraPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayTraPhong.TabIndex = 61;
            // 
            // dtNgayNhanPhong
            // 
            this.dtNgayNhanPhong.CustomFormat = "yyyy/MM/dd";
            this.dtNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhanPhong.Location = new System.Drawing.Point(631, 37);
            this.dtNgayNhanPhong.Name = "dtNgayNhanPhong";
            this.dtNgayNhanPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayNhanPhong.TabIndex = 60;
            // 
            // dtNgayDatPhong
            // 
            this.dtNgayDatPhong.CustomFormat = "yyyy/MM/dd";
            this.dtNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDatPhong.Location = new System.Drawing.Point(93, 89);
            this.dtNgayDatPhong.Name = "dtNgayDatPhong";
            this.dtNgayDatPhong.Size = new System.Drawing.Size(276, 20);
            this.dtNgayDatPhong.TabIndex = 62;
            // 
            // dtgChi
            // 
            this.dtgChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgChi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtgChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChi.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dtgChi.Location = new System.Drawing.Point(2, 211);
            this.dtgChi.Name = "dtgChi";
            this.dtgChi.Size = new System.Drawing.Size(925, 236);
            this.dtgChi.TabIndex = 49;
            this.dtgChi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChi_RowEnter);
            // 
            // btUpd
            // 
            this.btUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btUpd.Location = new System.Drawing.Point(529, 453);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(87, 44);
            this.btUpd.TabIndex = 48;
            this.btUpd.Text = "Sửa thông tin";
            this.btUpd.UseVisualStyleBackColor = false;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btAdd.Location = new System.Drawing.Point(274, 453);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(97, 44);
            this.btAdd.TabIndex = 47;
            this.btAdd.Text = "Đặt phòng";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(93, 114);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(276, 86);
            this.txtGhiChu.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Loại hình thuê";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(93, 10);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(276, 20);
            this.txtMaNV.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Ngày trả phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày đặt phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ngày nhận phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã nhân viên";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btXoa.Enabled = false;
            this.btXoa.Location = new System.Drawing.Point(413, 453);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(87, 44);
            this.btXoa.TabIndex = 67;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtLoaiHinhThue
            // 
            this.txtLoaiHinhThue.DisplayMember = "MaPhong";
            this.txtLoaiHinhThue.FormattingEnabled = true;
            this.txtLoaiHinhThue.Items.AddRange(new object[] {
            "Ngày",
            "Giờ"});
            this.txtLoaiHinhThue.Location = new System.Drawing.Point(631, 89);
            this.txtLoaiHinhThue.Name = "txtLoaiHinhThue";
            this.txtLoaiHinhThue.Size = new System.Drawing.Size(276, 21);
            this.txtLoaiHinhThue.TabIndex = 65;
            this.txtLoaiHinhThue.ValueMember = "MaPhong";
            // 
            // FrmChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(928, 507);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtLoaiHinhThue);
            this.Controls.Add(this.cbbMaPhong);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.dtNgayTraPhong);
            this.Controls.Add(this.dtNgayNhanPhong);
            this.Controls.Add(this.dtNgayDatPhong);
            this.Controls.Add(this.dtgChi);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
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
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dtNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dtNgayNhanPhong;
        private System.Windows.Forms.DateTimePicker dtNgayDatPhong;
        private System.Windows.Forms.DataGridView dtgChi;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QLKhachSanDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private QLKhachSanDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ComboBox txtLoaiHinhThue;
    }
}