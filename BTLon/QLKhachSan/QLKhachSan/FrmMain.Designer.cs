namespace QLKhachSan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUngDungLienKet = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btChiTietThue = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::QLKhachSan.Properties.Resources.IMG_5579;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(58, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 420);
            this.panel1.TabIndex = 0;
            // 
            // btUngDungLienKet
            // 
            this.btUngDungLienKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btUngDungLienKet.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUngDungLienKet.Location = new System.Drawing.Point(679, 52);
            this.btUngDungLienKet.Name = "btUngDungLienKet";
            this.btUngDungLienKet.Size = new System.Drawing.Size(187, 78);
            this.btUngDungLienKet.TabIndex = 1;
            this.btUngDungLienKet.Text = "Ứng Dụng Liên Kết";
            this.btUngDungLienKet.UseVisualStyleBackColor = false;
            this.btUngDungLienKet.Click += new System.EventHandler(this.btUngDungLienKet_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btKhachHang.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.Location = new System.Drawing.Point(679, 136);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(187, 84);
            this.btKhachHang.TabIndex = 1;
            this.btKhachHang.Text = "Khách Hàng";
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btChiTietThue
            // 
            this.btChiTietThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btChiTietThue.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiTietThue.Location = new System.Drawing.Point(679, 226);
            this.btChiTietThue.Name = "btChiTietThue";
            this.btChiTietThue.Size = new System.Drawing.Size(187, 80);
            this.btChiTietThue.TabIndex = 1;
            this.btChiTietThue.Text = "Chi Tiết Thuê";
            this.btChiTietThue.UseVisualStyleBackColor = false;
            this.btChiTietThue.Click += new System.EventHandler(this.btChiTietThue_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHoaDon.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDon.Location = new System.Drawing.Point(679, 312);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(187, 78);
            this.btHoaDon.TabIndex = 1;
            this.btHoaDon.Text = "Hóa Đơn";
            this.btHoaDon.UseVisualStyleBackColor = false;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btNhanVien.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.Location = new System.Drawing.Point(679, 396);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(187, 76);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Nhân Viên";
            this.btNhanVien.UseVisualStyleBackColor = false;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackgroundImage = global::QLKhachSan.Properties.Resources.Cancel;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.Location = new System.Drawing.Point(845, 509);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(36, 28);
            this.btThoat.TabIndex = 2;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(906, 549);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.btHoaDon);
            this.Controls.Add(this.btChiTietThue);
            this.Controls.Add(this.btKhachHang);
            this.Controls.Add(this.btUngDungLienKet);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btUngDungLienKet;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btChiTietThue;
        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btThoat;



    }
}