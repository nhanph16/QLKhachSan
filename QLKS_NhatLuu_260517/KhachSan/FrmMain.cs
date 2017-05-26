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
using HotelDAL;

namespace KhachSan
{
    public partial class FrmMain : Form
    {
        LINQDataContext db = new LINQDataContext();
        public int MaNV = 1;
        
        public FrmMain()
        {
            InitializeComponent();
        }
        

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            FrmEmployee FEmp = new FrmEmployee();
            FEmp.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (MaNV != 1)
            {
                menuNhanVien.Enabled = false;
                menuDanhSachTaiKhoan.Enabled = false;
            }
            else
            {
                menuNhanVien.Enabled = true;
                menuDanhSachTaiKhoan.Enabled = true;
            }

            txtWelcome.Text = "Xin chào " + db.NhanViens.Where(c => c.MaNV == MaNV).FirstOrDefault().TenNV;

            
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frm = new FrmDoiMatKhau();
            frm.MaNV = MaNV;
            frm.ShowDialog();
        }

        private void menuDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frm = new FrmTaiKhoan();
            frm.ShowDialog();
        }


        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int MaPhong = int.Parse(bt.Text[0].ToString());
            if (bt.BackColor == Color.LightBlue)
            {
                bool available = false;
                List<ChiTietPhong> list = db.ChiTietPhongs.Where(c => c.MaPhong == MaPhong).ToList();
                foreach (ChiTietPhong item in list)
                {
                    if (item.TrangThaiPhong == true)
                    {
                        available = true;
                    }
                }
                if (available == true)
                {
                    MessageBox.Show("Phòng đang bận");
                }
                else
                {
                    FrmCustomer FCus = new FrmCustomer();
                    FCus.MaNV = MaNV;
                    FCus.MaPhong = int.Parse(bt.Text[0].ToString());
                    FCus.btChonPhong.Visible = true;
                    FCus.ShowDialog();
                    db = new LINQDataContext();
                }
            }
            if (bt.BackColor == Color.LightGreen)
            {
                List<ChiTietPhong> list = db.ChiTietPhongs.Where(c => c.MaPhong == MaPhong).ToList();
                foreach (ChiTietPhong item in list)
                {
                    if (item.TrangThaiPhong == true)
                    {
                        FrmThanhToan frm = new FrmThanhToan();
                        frm.ChiTiet = item;
                        frm.MaNV = MaNV;
                        frm.ShowDialog();
                        db = new LINQDataContext();
                    }
                }
            }
        }

        private void rdDaDat_CheckedChanged(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            int Size = db.Phongs.Count();
            int x = 20, y = 2;
            for (int i = 0; i < Size; i++)
            {
                Button bt = new Button();
                Phong phong = db.Phongs.ToList()[i];
                List<ChiTietPhong> cp = db.ChiTietPhongs.Where(c => c.MaPhong == phong.MaPhong).ToList();
                string phongso = phong.MaPhong.ToString();
                bt.Click += Bt_Click;
                bool available = false;

                foreach (ChiTietPhong item in cp)
                {
                    if (item.TrangThaiPhong == true)
                        available = true;
                }

                if (available == true)
                {
                    bt.Location = new Point(x, y);
                    bt.BackColor = Color.LightGreen;
                    bt.Text = phongso;
                    bt.Size = new System.Drawing.Size(150, 75);
                    pnButton.Controls.Add(bt);
                    x += bt.Width + 10;
                }
            }
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            int Size = db.Phongs.Count();
            int x = 20, y = 2;
            for (int i = 0; i < Size; i++)
            {
                Button bt = new Button();
                Phong phong = db.Phongs.ToList()[i];
                List<ChiTietPhong> cp = db.ChiTietPhongs.Where(c => c.MaPhong == phong.MaPhong).ToList();
                string phongso = phong.MaPhong.ToString();
                bt.Location = new Point(x, y);
                bt.Text = phongso;
                bt.Size = new System.Drawing.Size(150, 75);
                bt.Click += Bt_Click;
                bool available = false;

                foreach (ChiTietPhong item in cp)
                {
                    if (item.TrangThaiPhong == true)
                        available = true;
                }

                if (available == true)
                {
                    bt.BackColor = Color.LightGreen;
                    pnButton.Controls.Add(bt);
                    x += bt.Width + 10;
                }
                else
                {
                    bt.BackColor = Color.LightBlue;
                    pnButton.Controls.Add(bt);
                    x += bt.Width + 10;
                }
            }
        }

        private void rdChuaDat_CheckedChanged(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            int Size = db.Phongs.Count();
            int x = 20, y = 2;
            for (int i = 0; i < Size; i++)
            {
                Button bt = new Button();
                Phong phong = db.Phongs.ToList()[i];
                List<ChiTietPhong> cp = db.ChiTietPhongs.Where(c=>c.MaPhong == phong.MaPhong).ToList();
                string phongso = phong.MaPhong.ToString();
                bt.Click += Bt_Click;
                bool available = false;

                foreach (ChiTietPhong item in cp)
                {
                    if (item.TrangThaiPhong == true)
                        available = true;
                }
                
                if (available == false)
                {
                    bt.Location = new Point(x, y);
                    bt.BackColor = Color.LightBlue;
                    bt.Text = phongso;
                    bt.Size = new System.Drawing.Size(150, 75);
                    pnButton.Controls.Add(bt);
                    x += bt.Width + 10;
                }
            }
        }

        private void menuChiTietPhong_Click(object sender, EventArgs e)
        {
            FrmChiTietPhong frm = new FrmChiTietPhong();
            frm.MaNV = MaNV;
            frm.ShowDialog();
            db = new LINQDataContext();

        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }

        private void menuPhong_Click(object sender, EventArgs e)
        {
            FrmPhong frm = new FrmPhong();
            frm.MaNV = MaNV;
            frm.ShowDialog();
        }
    }
}
