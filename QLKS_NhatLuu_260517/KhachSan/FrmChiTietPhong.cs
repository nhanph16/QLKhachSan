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
using HotelDAL;

namespace KhachSan
{
    public partial class FrmChiTietPhong : Form
    {
        LINQDataContext db;
        public int MaNV;
        public bool DatPhong = false;
        public int MaKH;
        public int MaPhong;
        public FrmChiTietPhong()
        {
            InitializeComponent();
        }

        public FrmChiTietPhong(int manv)
        {
            MaNV = manv;
        }
        

        private void LoadData()
        {
            try
            {
                db = new LINQDataContext();
                dtgChi.DataSource = from c in db.ChiTietPhongs
                                    select new {c.MaNV,c.MaKH,c.MaPhong,c.NgayDatPhong,c.NgayNhanPhong,c.NgayTraPhong,c.LoaiHinhThue,c.ThanhTien,c.GhiChu,c.TrangThaiPhong };
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmChiTietPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.qLKhachSanDataSet.Phong);
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLKhachSanDataSet.KhachHang);
            txtMaNV.Text = MaNV.ToString();
            if (MaNV == 1)
                btXoa.Enabled = true;
            LoadData();
            if(DatPhong == true)
            {
                cbbMaKH.Enabled = false;
                cbbMaKH.Text = MaKH.ToString();
                cbbMaPhong.Enabled = false;
                cbbMaPhong.Text = MaPhong.ToString();
                btXoa.Enabled = false;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            List<ChiTietPhong> list = db.ChiTietPhongs.Where(c => c.MaPhong == int.Parse(cbbMaPhong.Text)).ToList();
            bool available = false;
            foreach (ChiTietPhong item in list)
            {
                if (item.TrangThaiPhong == true)
                {
                    available = true;
                }
            }
            if (available == true)
                MessageBox.Show("Phòng đang bận");
            else
            {
                try
                {
                    if (dtNgayDatPhong.Value > dtNgayNhanPhong.Value)
                        MessageBox.Show("Ngày đặt không lớn hơn ngày nhận phòng");
                    else
                    {
                        ChiTietPhong ct = new ChiTietPhong();
                        ct.MaNV = int.Parse(txtMaNV.Text);
                        ct.MaKH = int.Parse(cbbMaKH.Text);
                        ct.MaPhong = int.Parse(cbbMaPhong.Text);
                        ct.NgayDatPhong = dtNgayDatPhong.Value;
                        ct.NgayNhanPhong = dtNgayNhanPhong.Value;
                        ct.NgayTraPhong = new DateTime(8888, 12, 30);
                        ct.LoaiHinhThue = txtLoaiHinhThue.Text;
                        ct.ThanhTien = 0;
                        ct.GhiChu = txtGhiChu.Text;
                        ct.TrangThaiPhong = true;
                        db.ChiTietPhongs.InsertOnSubmit(ct);
                        db.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Thêm thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgChi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            if (DatPhong == false)
            {
                this.cbbMaKH.Text = dtgChi.Rows[dong].Cells[1].Value.ToString();
                this.cbbMaPhong.Text = dtgChi.Rows[dong].Cells[2].Value.ToString();
            }
            this.dtNgayDatPhong.Text = dtgChi.Rows[dong].Cells[3].Value.ToString();
            this.dtNgayNhanPhong.Text = dtgChi.Rows[dong].Cells[4].Value.ToString();
            this.dtNgayTraPhong.Text = dtgChi.Rows[dong].Cells[5].Value.ToString();
            this.txtLoaiHinhThue.Text = dtgChi.Rows[dong].Cells[6].Value.ToString();
            this.txtThanhTien.Text = dtgChi.Rows[dong].Cells[7].Value.ToString();
            this.txtGhiChu.Text = dtgChi.Rows[dong].Cells[8].Value.ToString();
            this.cbTrangThai.Checked = bool.Parse(dtgChi.Rows[dong].Cells[9].Value.ToString());
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietPhong ct = new ChiTietPhong();
                ct.MaNV = int.Parse(txtMaNV.Text);
                ct.MaKH = int.Parse(cbbMaKH.Text);
                ct.MaPhong = int.Parse(cbbMaPhong.Text);
                ct.NgayDatPhong = dtNgayDatPhong.Value;
                ct.NgayNhanPhong = dtNgayNhanPhong.Value;
                ct.NgayTraPhong = dtNgayTraPhong.Value;
                ct.LoaiHinhThue = txtLoaiHinhThue.Text;
                ct.ThanhTien = int.Parse(txtThanhTien.Text);
                ct.GhiChu = txtGhiChu.Text;
                ct.TrangThaiPhong = cbTrangThai.Checked;
                ChiTietPhong chitiet = db.ChiTietPhongs.Where(c => c == ct).FirstOrDefault();
                chitiet.MaNV = ct.MaNV;
                chitiet.LoaiHinhThue = ct.LoaiHinhThue;
                chitiet.GhiChu = ct.GhiChu;
                db.SubmitChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giá trị nhập không hợp lệ");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete ChiTietPhong where MaKH = " + cbbMaKH.Text + " and MaPhong = " + cbbMaPhong.Text +
                " and NgayDatPhong = convert(date,'" + dtNgayDatPhong.Text + "',103) and NgayNhanPhong = convert(date, '" +
                dtNgayNhanPhong.Text + "',103) and NgayTraPhong = convert(date,'" + dtNgayTraPhong.Text + "',103)";
            new ChiTietPhongBUS().ExecQuery(sql);
            LoadData();
        }
    }
}
