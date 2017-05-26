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
    public partial class FrmPhong : Form
    {
        LINQDataContext db;
        public int MaNV;

        public FrmPhong()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            db = new LINQDataContext();
            dgvRoom.DataSource = db.Phongs.ToList();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.qLKhachSanDataSet.Phong);
            LoadData();

            if (MaNV != 1)
            {
                btDel.Enabled = false;
                btAdd.Enabled = false;
                btUpd.Enabled = false;
                txtGhiChu.Enabled = false;
                txtMaPhong.Enabled = false;
                txtSoGiuong.Enabled = false;
                dgvRoom.Enabled = false;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Phong p = new Phong();
                p.MaPhong = int.Parse(txtMaPhong.Text);
                p.SoGiuong = int.Parse(txtSoGiuong.Text);
                p.GhiChu = txtGhiChu.Text;
                db.Phongs.InsertOnSubmit(p);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            try
            {
                Phong p = db.Phongs.Where(c => c.MaPhong == int.Parse(txtMaPhong.Text)).FirstOrDefault();
                p.SoGiuong = int.Parse(txtSoGiuong.Text);
                p.GhiChu = txtGhiChu.Text;
                db.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
            LoadData();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                Phong p = db.Phongs.Where(c => c.MaPhong == int.Parse(txtMaPhong.Text)).FirstOrDefault();
                db.Phongs.DeleteOnSubmit(p);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
            LoadData();
        }
    }
}
