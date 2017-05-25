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
using Microsoft.Reporting.WinForms;

using DTO;
using BUS;

namespace QLKhachSan
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        string str; SqlConnection cn;
        DataSet ds; DataTable dtnv;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            str = "server =. ; database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
            dgvNhanVien.DataSource = GetNV();            
            loadChamCong();
            loadTinhLuong();
            
            load();
            
        }
        private DataTable GetTable(string sql)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void load()
        {
            //string sql = @"SELECT * FROM NhanVien";
            //dtnv = GetTable(sql);
            //cbbMaNV.DataSource = dtnv;
            //cbbMaNV.DisplayMember = "MaNV";
            //cbbMaNV.ValueMember = "MaNV";

            // load ccb cho cham cong
            string sql = @"SELECT * FROM NhanVien";
            dtnv = GetTable(sql);
            cbbChamCongMaNV.DataSource = dtnv;
            cbbChamCongMaNV.DisplayMember = "MaNV";
            cbbChamCongMaNV.ValueMember = "MaNV";
            //load cbb tinh luong
            sql = @"SELECT * FROM NhanVien";
            dtnv = GetTable(sql);
            cbbMaNVTL.DataSource = dtnv;
            cbbMaNVTL.DisplayMember = "MaNV";
            cbbMaNVTL.ValueMember = "MaNV";

            //load cac thang
            sql = @"SELECT * FROM ThangTrongNam";
            dtnv = GetTable(sql);
            cbbThang.DataSource = dtnv;
            cbbThang.DisplayMember = "TenThang";
            cbbThang.ValueMember = "TenThang";
        }
        // tim kiem 
        public void loadMaNV()
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNV='" + txtTimKiem.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiemNV.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadTenNV()
        {
            string sql = "SELECT * FROM NhanVien WHERE Ten='" + txtTimKiem.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiemNV.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaTK.Checked == true)
                loadMaNV();
            else
                loadTenNV();
        }

        //them sua xoa
        public List<DTONhanVien> GetNV()
        {

            string sql = "SELECT * FROM NhanVien";
            return new BUSNhanVien().GetNV(sql);
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            xoaTinhLuong();
            SqlConnection cnn = new SqlConnection(str);
            string s = "DELETE FROM NhanVien where MaNV='" + txtMaNV.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvNhanVien.DataSource = GetNV();
            load();
            cnn.Close();
        }
        public void xoaTinhLuong()
        {
            string sql = "DELETE FROM TinhLuongNV where MaNV='" + txtMaNV.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);              

            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void XoaNV()
        {
            txtTenNV.Text = ""; txtSDT.Text = "";
            txtGioiTinh.Text = ""; txtDiaChi.Text = "";
            dtpNgaySinh.Text = dtpNgaySinh.Value.ToString("1/1/1900");
            txtBangCap.Text = ""; txtCMND.Text = "";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = ""; txtHoNV.Text = "";
            XoaNV();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            this.txtHoNV.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            this.txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgaySinh.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
            this.txtGioiTinh.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
            this.txtCMND.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            this.txtSDT.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            this.txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
            this.txtBangCap.Text = dgvNhanVien.Rows[dong].Cells[8].Value.ToString(); 
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, cmnd, dc, sdt, gt, bc; DateTime ngaysinh;
            ma = txtMaNV.Text.Trim();
            ho = txtHoNV.Text.Trim();
            ten = txtTenNV.Text.Trim();
            ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
            cmnd = txtCMND.Text.Trim();
            sdt = txtSDT.Text.Trim();
            dc = txtDiaChi.Text.Trim();
            gt = txtGioiTinh.Text.Trim();
            bc = txtBangCap.Text.Trim();

            DTONhanVien nv = new DTONhanVien(ma, ho, ten, ngaysinh, gt, cmnd, sdt, dc, bc);
            try
            {
                int i = new BUSNhanVien().Add(nv);
                dgvNhanVien.DataSource = GetNV();
                load();

                XoaNV();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            tabControl1.SelectedTab =tabControl1.TabPages[3];
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE NhanVien Set Ho='" + txtHoNV.Text + "' ,Ten='" + txtTenNV.Text + "',NgaySinh='" + dtpNgaySinh.Text
                + "',CMND='" + txtCMND.Text + "',DiaChi='" + txtDiaChi.Text + "',SDT='" + txtSDT.Text
                + "',GioiTinh='" + txtGioiTinh.Text + "',BangCap='" + txtBangCap.Text + "'WHERE MaNV='" + txtMaNV.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvNhanVien.DataSource = GetNV();
            cnn.Close();
        }

        //report
        public void loadDSNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbNhanVien", dt); 
            rpvNhanVien.LocalReport.DataSources.Clear();
            rpvNhanVien.LocalReport.DataSources.Add(rds);
            rpvNhanVien.LocalReport.ReportPath = @"..\QLKhachSan\rptNhanVien.rdlc";
            this.rpvNhanVien.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDSNhanVien.Checked == true)
                loadDSNhanVien();
        }

        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
        }
        //Phần chấm công
        public void loadChamCong()
        {
            string sql = "SELECT * FROM BangChamCongNV";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvChamCong.DataSource = ds.Tables[0];
                
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void btThemChamCong_Click(object sender, EventArgs e)
        {
            
            string s = "INSERT INTO BangChamCongNV(MaNV,NgayCong,GioVao) VALUES ('" + cbbChamCongMaNV.Text + "','" + dtpNgayCong.Text
                + "','" + dtpGioVao.Text +  "')";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadChamCong();
            cnn.Close(); 
        }

        private void btSuaChamCong_Click(object sender, EventArgs e)
        {
            // chi sua gio ra va gio vao neu can thiet
            string s = "UPDATE BangChamCongNV Set GioRa='" + dtpGioRa.Text
               + "'WHERE MaNV='" + cbbChamCongMaNV.Text + "'and NgayCong='" + dtpNgayCong.Text + "'";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadChamCong();
            cnn.Close(); 
        }

        private void btXoaChamCong_Click(object sender, EventArgs e)
        {
            string s = "DELETE FROM BangChamCongNV WHERE MaNV='" + cbbChamCongMaNV.Text + "'and NgayCong='"+dtpNgayCong.Text+"'";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadChamCong();
            cn.Close();
        }

        private void dgvChamCong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbChamCongMaNV.Text = dgvChamCong.Rows[dong].Cells[0].Value.ToString();
            this.dtpNgayCong.Text = dgvChamCong.Rows[dong].Cells[1].Value.ToString();
            //this.dtpGioVao.Text = dgvChamCong.Rows[dong].Cells[2].Value.ToString();
            //this.dtpGioRa.Text = dgvChamCong.Rows[dong].Cells[3].Value.ToString();
        }

        private void btResetChamCong_Click(object sender, EventArgs e)
        {
            dtpGioVao.Text = dtpGioVao.Value.ToString("00:00");
            dtpGioRa.Text = dtpGioRa.Value.ToString("00:00");
            dtpNgayCong.Text = dtpNgayCong.Value.ToString("1/1/1900");
        }
        // Tính Lương

        public void loadTinhLuong()
        {
            string sql = "SELECT MaNV,ChucVu,LuongCB,HSLuong,HSPhuCap,Thue,Luong FROM TinhLuongNV";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTinhLuong.DataSource = ds.Tables[0];               

            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        private void dgvTinhLuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaNVTL.Text = dgvTinhLuong.Rows[dong].Cells[0].Value.ToString();
            this.txtChucVuTL.Text = dgvTinhLuong.Rows[dong].Cells[1].Value.ToString();
            this.txtLuongCB.Text = dgvTinhLuong.Rows[dong].Cells[2].Value.ToString();
            this.txtHSLuong.Text = dgvTinhLuong.Rows[dong].Cells[3].Value.ToString();
            this.txtHSPhuC.Text = dgvTinhLuong.Rows[dong].Cells[4].Value.ToString();
            this.txtThue.Text = dgvTinhLuong.Rows[dong].Cells[5].Value.ToString();
           // this.txtLuong.Text = dgvTinhLuong.Rows[dong].Cells[0].Value.ToString();
            loadChamCongHT();

        }
        public void loadChamCongHT()
        {
            string ma = cbbMaNVTL.Text;
            string sql = "SELECT NgayCong FROM BangChamCongNV WHERE MaNV='" + ma.ToString() +"'" ;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvChamCongHT.DataSource = ds.Tables[0];  
                DemSoNgay();

            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
       
        public void DemSoNgay()
        {
            int tien = dgvChamCongHT.Rows.Count; // ten datagridview
            tien = tien - 1;
            txtSoNgay.Text = tien.ToString(); 
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChamCongHT();
        }

        private void btClick_Click(object sender, EventArgs e)
        {
            loadChamCongHT();
        }
        public void tinhluong()
        {
            float lcb = float.Parse(txtLuongCB.Text);
            float hsl = float.Parse(txtHSLuong.Text);
            float hspc = float.Parse(txtHSPhuC.Text);
            float t = float.Parse(txtThue.Text);
            int songay = int.Parse(txtSoNgay.Text);
            int ngaynghi;
            float tam = 0,luong = 0;
            if ( songay == 26)
            {
                tam = lcb * hsl + lcb * hspc;
                luong = tam * t;
            }
            else if ( songay < 26)
            {
                tam = lcb * hsl + lcb * hspc;
                luong = tam * t;
                ngaynghi = 26 - songay;
                luong = luong - ngaynghi * 30000;
            }
            else
            {
                tam = lcb * hsl + lcb * hspc;
                luong = tam * t;
                ngaynghi = songay - 26;
                luong = luong + ngaynghi * 150000;
            }
            txtLuong.Text = luong.ToString();
        }
        public void updateLuong()
        {
            string sql = "UPDATE TinhLuongNV set Luong ='" + txtLuong.Text + "'where MaNV='"+cbbMaNVTL.Text+"'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                loadTinhLuong();           

            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void btTinhLuong_Click(object sender, EventArgs e)
        {
            tinhluong();
            updateLuong();
        }

        // sauk hi them nhan vien vao se phai them bang TinhLuong Nhan Vien 
        private void btThemTT_Click(object sender, EventArgs e)
        {
            string s = "INSERT INTO TinhLuongNV(MaNV,ChucVu,LuongCB,HSLuong,HSPhuCap,Thue) VALUES ('" + cbbMaNVTL.Text + "','" + txtChucVuTL.Text
                + "','" + txtLuongCB.Text + "','" + txtHSLuong.Text + "','" + txtHSPhuC.Text + "','" + txtThue.Text + "')";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadTinhLuong();
            cnn.Close(); 
        }
        


    }
}
