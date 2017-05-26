using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDAL;

namespace KhachSan
{
    public partial class FrmDoiMatKhau : Form
    {
        LINQDataContext db = new LINQDataContext();
        public int MaNV;

        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (db.TaiKhoans.Where(c => c.MaNV == MaNV).FirstOrDefault().MatKhau != txtMatKhauCu.Text)
            {
                MessageBox.Show("Sai mật khẩu, yêu cầu nhập lại");
            }
            else if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp với mật khẩu xác nhận");
            }
            else
            {
                TaiKhoan tk = db.TaiKhoans.Where(c => c.MaNV == MaNV).FirstOrDefault();
                tk.MatKhau = txtMatKhauMoi.Text;
                db.SubmitChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
        }
    }
}
