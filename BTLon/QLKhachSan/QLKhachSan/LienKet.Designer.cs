namespace QLKhachSan
{
    partial class LienKet
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbDSKhachSan = new System.Windows.Forms.RadioButton();
            this.rbDSLienHe = new System.Windows.Forms.RadioButton();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trung Tâm Quản Lý Khách Sạn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "------------------------------&&-----------------------------------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbDSKhachSan
            // 
            this.rbDSKhachSan.AutoSize = true;
            this.rbDSKhachSan.Checked = true;
            this.rbDSKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDSKhachSan.Location = new System.Drawing.Point(96, 191);
            this.rbDSKhachSan.Name = "rbDSKhachSan";
            this.rbDSKhachSan.Size = new System.Drawing.Size(244, 24);
            this.rbDSKhachSan.TabIndex = 3;
            this.rbDSKhachSan.TabStop = true;
            this.rbDSKhachSan.Text = "Danh Sách Các Khách Sạn";
            this.rbDSKhachSan.UseVisualStyleBackColor = true;
            // 
            // rbDSLienHe
            // 
            this.rbDSLienHe.AutoSize = true;
            this.rbDSLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDSLienHe.Location = new System.Drawing.Point(96, 308);
            this.rbDSLienHe.Name = "rbDSLienHe";
            this.rbDSLienHe.Size = new System.Drawing.Size(183, 24);
            this.rbDSLienHe.TabIndex = 3;
            this.rbDSLienHe.Text = "Danh Sách Liên Hệ";
            this.rbDSLienHe.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btThoat.BackgroundImage = global::QLKhachSan.Properties.Resources.Cancel;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.Location = new System.Drawing.Point(709, 437);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(56, 46);
            this.btThoat.TabIndex = 4;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = global::QLKhachSan.Properties.Resources.timkiem;
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiem.Location = new System.Drawing.Point(443, 201);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(84, 56);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::QLKhachSan.Properties.Resources.victory_vung_tau2;
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(766, 483);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // LienKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.rbDSLienHe);
            this.Controls.Add(this.rbDSKhachSan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LienKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LienKet";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDSKhachSan;
        private System.Windows.Forms.RadioButton rbDSLienHe;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThoat;
    }
}