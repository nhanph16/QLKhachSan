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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        string str; SqlConnection cn; DataTable dtkh,dtmanvr; DataSet ds;
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            str = "server =. ; database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
            load();
            dgvHoaDon.DataSource = GetHD();
            this.rpvHoaDon.RefreshReport();           
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
            string sql = @"SELECT * FROM DSKhachHang";
            dtkh = GetTable(sql);
            cbbMaKH.DataSource = dtkh;
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";

            // lay du lieu cho in hoa don
            //string s = "kt";
            sql = "SELECT * FROM TinhLuongNV";// where GhiChu='" + s.ToString() + "'";
            dtmanvr = GetTable(sql);
            cbbMaNV.DataSource = dtmanvr;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";

            // load thag xuat hoa don
            sql = @"SELECT * FROM ThangTrongNam";
            dtkh = GetTable(sql);
            cbbThangXuatHD.DataSource = dtkh;
            cbbThangXuatHD.DisplayMember = "TenThang";
            cbbThangXuatHD.ValueMember = "TenThang";
        }
        public void loadtimkiemMaHD()
        {
            string sql = "SELECT * FROM HoaDon WHERE MaHD='" + txtTimKiem.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiem.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        public void loadtimkiemMaKH()
        {
            string sql = "SELECT * FROM HoaDon WHERE MaKH='" + txtTimKiem.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiem.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadtimkiemMaNV()
        {
            string sql = "SELECT * FROM HoaDon WHERE MaNV='" + txtTimKiem.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiem.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaHDTimkiem.Checked == true)
                loadtimkiemMaHD();
            else if (rbMaKHTimKiem.Checked == true)
                loadtimkiemMaKH();
            else
                loadtimkiemMaNV();
        }
        // them xoa sua
        public List<DTOHoaDon> GetHD()
        {
            string sql = "SELECT * FROM HoaDon";
            return new BUSHoaDon().GetHD(sql);
        }

        private void btThemHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaHD.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();
            //this.cbbMaKH.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString();
            this.dtpNgayXuat.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
            this.txtThanhTien.Text = dgvHoaDon.Rows[dong].Cells[3].Value.ToString();
            this.txtMaNV.Text = dgvHoaDon.Rows[dong].Cells[4].Value.ToString();
            loadCTHDHoTro();
          
        }
        public void xoatrangHD()
        {
            cbbMaKH.Text = "";
            dtpNgayXuat.Text = dtpNgayXuat.Value.ToString("1/1/1900");
            txtThanhTien.Text = "0";
            txtMaNV.Text = "NV17000";
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            if ( txtThanhTien.Text == "0")
            {
                string mh, mk, mv; DateTime nx; int tt;
                mh = txtMaHD.Text.Trim();
                mk = cbbMaKH.Text.Trim();
                nx = Convert.ToDateTime(dtpNgayXuat.Text);
                tt = int.Parse(txtThanhTien.Text);
                mv = txtMaNV.Text.Trim();

                DTOHoaDon hd = new DTOHoaDon(mh, mk, nx, tt, mv);
                try
                {
                    int i = new BUSHoaDon().Add(hd);
                    dgvHoaDon.DataSource = GetHD();
                    load();
                    xoatrangHD();
                    txtMaHD.Text = "";
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chưa Reset lại!");
            }
           
        }

        private void btSuaHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "UPDATE HoaDon SET NgayXuat='" + dtpNgayXuat.Text + "',ThanhTien='" + txtThanhTien.Text
            + "',MaNV='" + txtMaNV.Text + "'WHERE MaKH='" + cbbMaKH.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvHoaDon.DataSource = GetHD();
            cn.Close();
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            xoaCTHD();
            SqlConnection cn = new SqlConnection(str);
            string s = "DELETE FROM HoaDon WHERE MaHD='" + txtMaHD.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvHoaDon.DataSource = GetHD();
            load();            
            cn.Close();
        }
       public void xoaCTHD()
        {
            string sql = "DELETE FROM CTHoaDon WHERE MaHD='" + txtMaHD.Text + "'";
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
        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            xoatrangHD();
        }
        public void loadCTHDHoTro()
        {
            string sql = @"SELECT * FROM  CTHoaDon where MaHD='" + txtMaHD.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvCTHD.DataSource = ds.Tables[0];
                tinhtongtienCTHD();
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }

        }
        public void loadCTHTcbbMaKH()
        {            
                string sql = @"SELECT * FROM  CTHoaDon where MaHD='" + txtMaHDHT.Text + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                    //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    ds = new DataSet();
                    da.Fill(ds);                    
                    dgvCTHD.DataSource = ds.Tables[0];                   
                    tinhtongtienCTHD();
                    
                }
                    
                catch (DataException e)
                {

                    MessageBox.Show("loi lien ket DL " + e.ToString());
                }            
           
        }
        // tinh tien
        public void loadGiaPhong()
        {
            string sql = "SELECT GiaPhong FROM  DSPhong where MaP='" + txtMaPhong.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvGiaPhong.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadMaPhong()
        {
            string sql = "SELECT MaP FROM  ChiTietThuePhong where MaKH='" + cbbMaKH.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvMaPhong.DataSource = ds.Tables[0];
                loadGiaPhong();
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadNgayThueTra()
        {
            string sql = "SELECT NgayThue,NgayTra FROM  ChiTietThuePhong where MaKH='" + cbbMaKH.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvNgayThue.DataSource = ds.Tables[0];
                dgvNgayThue.Columns["NgayThue"].Width = 200;
                dgvNgayThue.Columns["NgayTra"].Width = 200;
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void dgvMaPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaPhong.Text = dgvMaPhong.Rows[dong].Cells[0].Value.ToString();
            loadGiaPhong();
            loadNgayThueTra();
        }

        private void dgvGiaPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtGiaPhong.Text = dgvGiaPhong.Rows[dong].Cells[0].Value.ToString();
        }
        private void btXemTT_Click(object sender, EventArgs e)
        {
            loadMaPhong();
            loadMaHDHotro();
            loadCTHTcbbMaKH();
        }
       
        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }     
        public void tinhtongtienCTHD()
        {
            int tien = dgvCTHD.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dgvCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            txtTongTien.Text = thanhtien.ToString();
        }
      public void loadMaHDHotro()
        {
            string sql = "SELECT MaHD FROM  HoaDon where MaKH='" + cbbMaKH.Text + "'";
            try
            {                
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvMaHDHoTro.DataSource = ds.Tables[0];
                // kiem tra neu hoa don nao chua co chi tiet hoa don thi hien rong 
                // neu khong no van hien et qua cua lan truoc
                if(dgvMaHDHoTro.DataSource == null)
                {
                    txtMaHDHT.Text = "";                    
                }
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

      private void dgvMaHDHoTro_RowEnter(object sender, DataGridViewCellEventArgs e)
      {
          int dong;
          dong = e.RowIndex;
          this.txtMaHDHT.Text = dgvMaHDHoTro.Rows[dong].Cells[0].Value.ToString();         
          loadCTHTcbbMaKH();
      }
        // tinh tong tien CTHD va thue phong    

      private void btTinhTongTien_Click(object sender, EventArgs e)
      {
          int tienphong = int.Parse(txtGiaPhong.Text);
          int tienCTHD = int.Parse(txtTongTien.Text);
          int thanhtien;
          int songay = int.Parse(txtSoNgay.Text);
          if (cbGio.Checked == true && cbNgay.Checked == false )
          {              
              thanhtien = (tienphong * 70) / 100 + tienCTHD;
              txtThanhTien.Text = thanhtien.ToString();
          }
          if(cbGio.Checked == false && cbNgay.Checked == true )
          {
              thanhtien = tienphong * songay + tienCTHD;
              txtThanhTien.Text = thanhtien.ToString();
          }
         
          loadtongtien();
      }
     void loadtongtien()
      {
          string sql = "UPDATE HOADON set ThanhTien='" + txtThanhTien.Text + "'where MaKH='" + cbbMaKH.Text + "'";
          try
          {

              SqlDataAdapter da = new SqlDataAdapter(sql, cn);
              //SqlCommandBuilder cb = new SqlCommandBuilder(da);
              ds = new DataSet();
              da.Fill(ds);
              dgvHoaDon.DataSource = GetHD();
          }
          catch (DataException e)
          {

              MessageBox.Show("loi lien ket DL " + e.ToString());
          }
      }

     private void btThemCTHoaDon_Click(object sender, EventArgs e)
     {
         FrmChiTietHoaDon f = new FrmChiTietHoaDon();
         f.Show();
     }

     private void btXuatHoaDon_Click(object sender, EventArgs e)
     {
         string sql = "SELECT * FROM HoaDon  where MaKH='" + cbbMaKH.Text + "'";
         DataTable dt = new DataTable();
         SqlDataAdapter da = new SqlDataAdapter(sql, cn);
         da.Fill(dt);
         ReportDataSource rds = new ReportDataSource("tbHoaDon", dt);
         rpvHoaDon.LocalReport.DataSources.Clear();
         rpvHoaDon.LocalReport.DataSources.Add(rds);
         rpvHoaDon.LocalReport.ReportPath = @"..\QLKhachSan\rptHoaDon.rdlc";
         this.rpvHoaDon.RefreshReport();

         //
        
     }

     private void FrmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
     {
         FrmMain f = new FrmMain();
         f.Show();
     }
    //report
    public void loadThangInHD()
     {
         int thang = int.Parse(cbbThangXuatHD.Text);
         int nam = int.Parse(txtNam.Text);
         string sql = "SELECT * FROM HoaDon  where Month(NgayXuat)='" + thang.ToString() + "'and year(NgayXuat)='"+nam.ToString()+"'";
         DataTable dt = new DataTable();
         SqlDataAdapter da = new SqlDataAdapter(sql, cn);
         da.Fill(dt);
         ReportDataSource rds = new ReportDataSource("tbDSHoaDon", dt);
         rpvHoaDon.LocalReport.DataSources.Clear();
         rpvHoaDon.LocalReport.DataSources.Add(rds);
         rpvHoaDon.LocalReport.ReportPath = @"..\QLKhachSan\rptDSHoaDon.rdlc";
         this.rpvHoaDon.RefreshReport();
         
     }
      public void loadMaNVInHD()
    {
        string sql = "SELECT * FROM HoaDon where MaNV='"+cbbMaNV.Text+"'";
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(sql, cn);
        da.Fill(dt);
        ReportDataSource rds = new ReportDataSource("tbDSHoaDon", dt);
        rpvHoaDon.LocalReport.DataSources.Clear();
        rpvHoaDon.LocalReport.DataSources.Add(rds);
        rpvHoaDon.LocalReport.ReportPath = @"..\QLKhachSan\rptDSHoaDon.rdlc";
        this.rpvHoaDon.RefreshReport();
    }
    private void btReport_Click(object sender, EventArgs e)
    {
        if (rbReportMa.Checked == true)
        {
            string sql = "SELECT * FROM HoaDon ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbDSHoaDon", dt);
            rpvHoaDon.LocalReport.DataSources.Clear();
            rpvHoaDon.LocalReport.DataSources.Add(rds);
            rpvHoaDon.LocalReport.ReportPath = @"..\QLKhachSan\rptDSHoaDon.rdlc";
            this.rpvHoaDon.RefreshReport();
        }
        else if (rbMaNV.Checked == true)
        {
            loadMaNVInHD();
        }
        else
            loadThangInHD();
    }

   

   

 
      
    }
}
