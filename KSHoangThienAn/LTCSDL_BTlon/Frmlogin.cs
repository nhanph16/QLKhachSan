using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LTCSDL_BTlon
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }
        string str = "";

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string sql = "SELECT * FROM TaiKhoan where TaiKhoan='" +txtTaiKhoan.Text 
                + "'and MatKhau='" + txtMatKhau.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            if ( reader.Read())
            {
                cn.Close();
                this.Hide();
                Frmmain f = new Frmmain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn Đăng Nhập không thành công!");
                txtMatKhau.Text = "";
                txtTaiKhoan.Text = "";
                txtTaiKhoan.Focus();
            }            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            str = "Server=. ; Database = KSHoangThienAn ; Integrated Security = true;";
            
        }



    }
}
