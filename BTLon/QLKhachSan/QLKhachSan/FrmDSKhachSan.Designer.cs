namespace QLKhachSan
{
    partial class FrmDSKhachSan
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
            this.dgvDSPhongConTrong = new System.Windows.Forms.DataGridView();
            this.dgvChiTietTungKS = new System.Windows.Forms.DataGridView();
            this.dgvDSKhongPhongTrong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKS = new System.Windows.Forms.TextBox();
            this.txtTongSoPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongConTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTungKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhongPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhongConTrong
            // 
            this.dgvDSPhongConTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhongConTrong.Location = new System.Drawing.Point(1, 69);
            this.dgvDSPhongConTrong.Name = "dgvDSPhongConTrong";
            this.dgvDSPhongConTrong.Size = new System.Drawing.Size(820, 160);
            this.dgvDSPhongConTrong.TabIndex = 0;
            this.dgvDSPhongConTrong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhongConTrong_RowEnter);
            // 
            // dgvChiTietTungKS
            // 
            this.dgvChiTietTungKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTungKS.Location = new System.Drawing.Point(1, 254);
            this.dgvChiTietTungKS.Name = "dgvChiTietTungKS";
            this.dgvChiTietTungKS.Size = new System.Drawing.Size(820, 152);
            this.dgvChiTietTungKS.TabIndex = 0;
            // 
            // dgvDSKhongPhongTrong
            // 
            this.dgvDSKhongPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhongPhongTrong.Location = new System.Drawing.Point(1, 431);
            this.dgvDSKhongPhongTrong.Name = "dgvDSKhongPhongTrong";
            this.dgvDSKhongPhongTrong.Size = new System.Drawing.Size(820, 76);
            this.dgvDSKhongPhongTrong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Chi Tiết Số Phòng Trống Các KS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh Sách Khách Sạn còn Phòng Trống:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi Tiết Số Phòng Trống:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh Sách Khách Sạn Không Còn Phòng Trống:";
            // 
            // txtMaKS
            // 
            this.txtMaKS.Location = new System.Drawing.Point(588, 273);
            this.txtMaKS.Name = "txtMaKS";
            this.txtMaKS.Size = new System.Drawing.Size(103, 20);
            this.txtMaKS.TabIndex = 4;
            // 
            // txtTongSoPhong
            // 
            this.txtTongSoPhong.Location = new System.Drawing.Point(711, 287);
            this.txtTongSoPhong.Name = "txtTongSoPhong";
            this.txtTongSoPhong.Size = new System.Drawing.Size(80, 20);
            this.txtTongSoPhong.TabIndex = 5;
            // 
            // FrmDSKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(822, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSKhongPhongTrong);
            this.Controls.Add(this.dgvChiTietTungKS);
            this.Controls.Add(this.dgvDSPhongConTrong);
            this.Controls.Add(this.txtTongSoPhong);
            this.Controls.Add(this.txtMaKS);
            this.MaximizeBox = false;
            this.Name = "FrmDSKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDSKhachSan";
            this.Load += new System.EventHandler(this.FrmDSKhachSan_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmDSKhachSan_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDSKhachSan_MouseDown);
            this.MouseLeave += new System.EventHandler(this.FrmDSKhachSan_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmDSKhachSan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongConTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTungKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhongPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhongConTrong;
        private System.Windows.Forms.DataGridView dgvChiTietTungKS;
        private System.Windows.Forms.DataGridView dgvDSKhongPhongTrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKS;
        private System.Windows.Forms.TextBox txtTongSoPhong;
    }
}