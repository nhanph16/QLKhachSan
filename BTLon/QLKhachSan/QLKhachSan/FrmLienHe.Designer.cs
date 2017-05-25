namespace QLKhachSan
{
    partial class FrmLienHe
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
            this.txtMaChuSH = new System.Windows.Forms.TextBox();
            this.dgvDSChuSoHuu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenChuSH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTChuSH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuSoHuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã :";
            // 
            // txtMaChuSH
            // 
            this.txtMaChuSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuSH.Location = new System.Drawing.Point(53, 3);
            this.txtMaChuSH.Name = "txtMaChuSH";
            this.txtMaChuSH.Size = new System.Drawing.Size(100, 24);
            this.txtMaChuSH.TabIndex = 2;
            // 
            // dgvDSChuSoHuu
            // 
            this.dgvDSChuSoHuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChuSoHuu.Location = new System.Drawing.Point(-1, 80);
            this.dgvDSChuSoHuu.Name = "dgvDSChuSoHuu";
            this.dgvDSChuSoHuu.Size = new System.Drawing.Size(533, 304);
            this.dgvDSChuSoHuu.TabIndex = 3;
            this.dgvDSChuSoHuu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSChuSoHuu_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên :";
            // 
            // txtTenChuSH
            // 
            this.txtTenChuSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuSH.Location = new System.Drawing.Point(53, 50);
            this.txtTenChuSH.Name = "txtTenChuSH";
            this.txtTenChuSH.Size = new System.Drawing.Size(100, 24);
            this.txtTenChuSH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SDT :";
            // 
            // txtSDTChuSH
            // 
            this.txtSDTChuSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTChuSH.Location = new System.Drawing.Point(249, 6);
            this.txtSDTChuSH.Name = "txtSDTChuSH";
            this.txtSDTChuSH.Size = new System.Drawing.Size(100, 24);
            this.txtSDTChuSH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ Liên Hệ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(283, 47);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(249, 24);
            this.txtDiaChi.TabIndex = 2;
            // 
            // FrmLienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.dgvDSChuSoHuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDTChuSH);
            this.Controls.Add(this.txtTenChuSH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaChuSH);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmLienHe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLienHe";
            this.Load += new System.EventHandler(this.FrmLienHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuSoHuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaChuSH;
        private System.Windows.Forms.DataGridView dgvDSChuSoHuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenChuSH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTChuSH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}