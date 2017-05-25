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

namespace QLKhachSan
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            var a = this.PointToScreen(label3.Location);
            a = pictureBox1.PointToClient(a);
            label3.Parent = pictureBox1;
            label3.Location = a;
            label3.BackColor = Color.Transparent;
            var b = this.PointToScreen(label2.Location);
            b = pictureBox1.PointToClient(b);
            label2.Parent = pictureBox1;
            label2.Location = b;
            label2.BackColor = Color.Transparent;
            var c = this.PointToScreen(label1.Location);
            c = pictureBox1.PointToClient(c);
            label1.Parent = pictureBox1;
            label1.Location = c;
            label1.BackColor = Color.Transparent;
        }
        string str = "";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string sql = "SELECT * FROM TaiKhoan where TaiKhoan='" + txtTaiKhoan.Text
                + "'and MatKhau='" + txtMatKhau.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cn.Close();
                this.Hide();
                FrmMain f = new FrmMain();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            str = "Server=. ; Database = KSHoangThienAn ; Integrated Security = true;";
            txtMatKhau.Text = "s123";
            txtTaiKhoan.Text = "ql";
        }
    }
       
}
