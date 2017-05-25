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
    public partial class FrmChiTietHoaDon : Form
    {
        public FrmChiTietHoaDon()
        {
            InitializeComponent();
        }
        string str; SqlConnection cn;
        DataTable dtsp, dthd,dtrp; DataSet ds;
        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            str = "server =. ; database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
            load();
            loadSanPham();
            loadSanPhamHT();
            dgvChiTietHoaDon.DataSource = GetCTHD();
            this.rpvSanPham.RefreshReport();
        }
        private DataTable GetTable(string sql)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public List<DTOCTHoaDon> GetCTHD()
        {
            string sql = "SELECT * FROM CTHoaDon";
            return new BUSCTHoaDon().GetCTHD(sql);
        }  
        public void load()
        {
            // show cac hoa don vao bang chi tiet hoa don
            string sql = @"SELECT * FROM HoaDon";
            dthd = GetTable(sql);
            cbbMaHD.DataSource = dthd;
            cbbMaHD.DisplayMember = "MaHD"; 
            cbbMaHD.ValueMember = "MaHD";
            // show bang san pham vao bang chi tiet
             sql = @"SELECT * FROM SanPham";
            dtsp = GetTable(sql);
            cbbMaSP.DataSource = dtsp;
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            //cho report
            sql = @"SELECT * FROM HoaDon";
            dtrp = GetTable(sql);
            cbbReportHoaDon.DataSource = dtrp;
            cbbReportHoaDon.DisplayMember = "MaHD";
            cbbReportHoaDon.ValueMember = "MaHD";
        }
        public void loadSanPham()
        {
            string sql = "SELECT * FROM SanPham";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvSanPham.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadSanPhamHT()
        {

            string sql = "SELECT MaSP, TenSP, Gia FROM SanPham";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvSanPhamHT.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;           
            this.txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString();
            this.txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString();
            this.txtSLTon.Text = dgvSanPham.Rows[dong].Cells[2].Value.ToString();
            this.txtGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString();           
        }

        private void btSuaSP_Click(object sender, EventArgs e)
        {
            string s = "UPDATE SanPham Set TenSP='" + txtTenSP.Text
                + "',SLTonKho='" + txtSLTon.Text + "',Gia='" + txtGia.Text + "'WHERE MaSP='" + txtMaSP.Text +  "'";
            SqlConnection cnn = new SqlConnection(str);            
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadSanPham();
            xoasp();
            cnn.Close(); 
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            string s = "INSERT INTO SanPham(MaSP,TenSP,SLTonKho,Gia) VALUES ('"+txtMaSP.Text+"','" + txtTenSP.Text
                + "','" + txtSLTon.Text + "','" + txtGia.Text + "')";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadSanPham();
            xoasp();
            cnn.Close(); 
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {

            string s = "DELETE FROM SanPham WHERE MaSP='" + txtMaSP.Text  + "'";
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadSanPham();
            xoasp();
            cnn.Close(); 
        }

        public void xoasp()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSLTon.Text = "";
            txtGia.Text = "";
        }
        private void btReSetSP_Click(object sender, EventArgs e)
        {
            xoasp();
        }

        
        private void dgvChiTietHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaSP.Text = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
            this.cbbMaHD.Text = dgvChiTietHoaDon.Rows[dong].Cells[0].Value.ToString();
            this.txtDonGia.Text = dgvChiTietHoaDon.Rows[dong].Cells[3].Value.ToString();
            this.txtSoLuong.Text = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
            this.txtThanhTien.Text = dgvChiTietHoaDon.Rows[dong].Cells[4].Value.ToString();
        }

        // Them chi tiet hoa don
        private void button5_Click(object sender, EventArgs e)
        {
            string m, ms;
            int sl, dg,tt;
            m = cbbMaHD.Text.Trim();
            ms = cbbMaSP.Text.Trim();
            sl = int.Parse(txtSoLuong.Text);
            dg = int.Parse(txtDonGia.Text);
            thanhTien();
            tt = int.Parse(txtThanhTien.Text);
            DTOCTHoaDon cthd = new DTOCTHoaDon(m, ms, sl, dg,tt);
            try
            {
                int i = new BUSCTHoaDon().Add(cthd);
                loadLaiSanPham();   
                dgvChiTietHoaDon.DataSource = GetCTHD();
                loadSanPham();             
                load();                
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        public void xoaCTHD()
        {

            cbbMaSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
        }
        public void thanhTien()
        {
            int a = int.Parse(txtSoLuong.Text);
            int b = int.Parse(txtDonGia.Text);
            int c = a * b;
            txtThanhTien.Text = c.ToString();
        }
        private void btSuaCTHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            // tinh tien
            int a = int.Parse(txtSoLuong.Text);
            int b = int.Parse(txtDonGia.Text);
            int c = a * b;
            txtThanhTien.Text = c.ToString();
            //
            string s = "UPDATE CTHoaDon SET SoLuong='" + txtSoLuong.Text + "',DonGia='" + txtDonGia.Text
            +"',ThanhTien='"+txtThanhTien.Text+ "'WHERE MaHD='" + cbbMaHD.Text + "' and MaSP='" + cbbMaSP.Text + "'";
            cn.Open();            
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();            
            dgvChiTietHoaDon.DataSource = GetCTHD();
            loadLaiSanPham();            
            xoaCTHD();
            cn.Close();
        }

        private void btXoaCTHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "DELETE FROM CTHoaDon WHERE MaHD='" + cbbMaHD.Text + "' and MaSP='" + cbbMaSP.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvChiTietHoaDon.DataSource = GetCTHD();
            load();
            cn.Close();
            xoaCTHD();
        }

        private void btResetCT_Click(object sender, EventArgs e)
        {
            cbbMaHD.Text = "";
            xoaCTHD();
        }
        // thay doi so luong san pham khi tao thanh cong 1 chi tiet hoa don
        public void loadLaiSanPham()
        {            
            int b = int.Parse(txtSoLuong.Text);
            string s = cbbMaSP.Text;
            string sql = "UPDATE SanPham Set SLTonKho=SLTonKho-'"+b.ToString()+ "'where MaSP='" + s.ToString()+ "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);                
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        private void dgvSanPhamHT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaSP.Text = dgvSanPhamHT.Rows[dong].Cells[0].Value.ToString();
            this.txtDonGia.Text = dgvSanPhamHT.Rows[dong].Cells[2].Value.ToString();
        }

        //report 
        public void reportChiTietHoaDon()
        {            
            string sql = "SELECT * FROM CTHoaDon WHERE MaHD='" + cbbReportHoaDon.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbCTHoaDon", dt);
            rpvSanPham.LocalReport.DataSources.Clear();
            rpvSanPham.LocalReport.DataSources.Add(rds);
            rpvSanPham.LocalReport.ReportPath = @"..\QLKhachSan\rptCTHoaDon.rdlc";
            this.rpvSanPham.RefreshReport();
        }
        public void reportSanPham()
        {
            string sql = "SELECT * FROM SanPham ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbSanPham", dt);
            rpvSanPham.LocalReport.DataSources.Clear();
            rpvSanPham.LocalReport.DataSources.Add(rds);
            rpvSanPham.LocalReport.ReportPath = @"..\QLKhachSan\rptSanPham.rdlc";
            this.rpvSanPham.RefreshReport();
        }
        public void reportCTHDfull()
        {
            string sql = "SELECT * FROM CTHoaDon ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbCTHoaDon", dt);
            rpvSanPham.LocalReport.DataSources.Clear();
            rpvSanPham.LocalReport.DataSources.Add(rds);
            rpvSanPham.LocalReport.ReportPath = @"..\QLKhachSan\rptCTHoaDon.rdlc";
            this.rpvSanPham.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdSanPham.Checked == true)
            {
                reportSanPham();
            }
            else if ( rdCTHoaDon.Checked == true && cbCTHoaDon.Checked == true)
            {
                reportCTHDfull();
            }
            else
            {
                reportChiTietHoaDon();
            }
        }

    }
}
