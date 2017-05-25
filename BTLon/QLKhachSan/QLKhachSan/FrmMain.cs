using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            this.Hide();
            f.Show();            
        }

        private void btChiTietThue_Click(object sender, EventArgs e)
        {
            FrmChiTietThue f = new FrmChiTietThue();
            this.Hide();
            f.Show();   
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            this.Hide();
            f.Show();   
        }

        private void btChiTietHoaDon_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon f = new FrmChiTietHoaDon();
            this.Hide();
            f.Show();   
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Hide();
            f.Show();   
        }

        private void btUngDungLienKet_Click(object sender, EventArgs e)
        {
            LienKet f = new LienKet();
            this.Hide();
            f.Show();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

     
    }
}
