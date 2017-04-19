using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class FrmMain : Form
    {
        public int MaNV;
        FrmLogin frm = new FrmLogin();
        public FrmMain()
        {
            frm.ShowDialog();
            InitializeComponent();
        }
        

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            FrmEmployee FEmp = new FrmEmployee();
            FEmp.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MaNV = frm.MaNV;
            if (MaNV != 1)
                menuNhanVien.Enabled = false;
            else
                menuNhanVien.Enabled = true;
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            FrmCustomer FCus = new FrmCustomer();
            FCus.btChonPhong.Visible = false;
            FCus.ShowDialog();
        }

        private void menuThuePhong_Click(object sender, EventArgs e)
        {
            FrmCustomer FCus = new FrmCustomer();
            FCus.MaNV = MaNV;
            FCus.btChonPhong.Visible = true;
            FCus.ShowDialog();
            
        }
    }
}
