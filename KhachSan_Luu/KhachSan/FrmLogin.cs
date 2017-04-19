using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBUS;
using System.Data.SqlClient;

namespace KhachSan
{
    public partial class FrmLogin : Form
    {
        public int MaNV { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }
        

        private void btLogin_Click(object sender, EventArgs e)
        {
            MaNV = 0;
            string MK = "";
            try
            {
                MaNV = int.Parse(txtId.Text);
                MK = txtPassword.Text.Trim();
                int i = new LoginBUS().CheckLogin(MaNV, MK);
                switch (i)
                {
                    case 1:
                        MessageBox.Show("Đăng nhập thành công");
                        this.Close();
                        break;
                    case 0:
                        MessageBox.Show("Tài khoản nhập không chính xác, vui lòng thử lại");
                        break;
                    case -1:
                        MessageBox.Show("Lỗi không xác định");
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
