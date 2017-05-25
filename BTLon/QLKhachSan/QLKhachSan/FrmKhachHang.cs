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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        string str; SqlConnection cn;
        DataSet ds; DataTable dtkh;
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            str = "server =. ; database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
            dgvThemKH.DataSource = GetKH();
            dgvXoaKH.DataSource = GetKH();
            load();           

            // report
            string sql = "SELECT * FROM DSKhachHang";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbKhachHang", dt); // tên b?ng mà mình kéo vào lúc t?o report
            rpvKhachHang.LocalReport.DataSources.Clear();
            rpvKhachHang.LocalReport.DataSources.Add(rds);
            rpvKhachHang.LocalReport.ReportPath = @"..\QLKhachSan\rptKhachHang.rdlc";
            this.rpvKhachHang.RefreshReport();
        }
        public List<DTOKhachHang> GetKH()
        {
            string sql = "SELECT * FROM DSKhachHang";
            return new BUSKhachHang().GetKH(sql);
        }
        public void load()
        {
            string sql = @"SELECT * FROM DSKhachHang";
            dtkh = GetTable(sql);
            cbbMaKH.DataSource = dtkh;
            cbbMaKH.DisplayMember = "MaKH"; // cai minh hien khi nhap vao combobox
            cbbMaKH.ValueMember = "MaKH";
        }
        private DataTable GetTable(string sql)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void loadMaKH()
        {
            string sql = "SELECT * FROM DSKhachHang WHERE MaKH='" + txtTimKiemKH.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiemKH.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadTenKH()
        {
            string sql = "SELECT * FROM DSKhachHang WHERE Ten='" + txtTimKiemKH.Text + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvTimKiemKH.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }

        private void btTimKiemKH_Click(object sender, EventArgs e)
        {
            if (rdMaKH.Checked == true)
            {
                loadMaKH();
            }
            else
            {
                loadTenKH();
            }
        }
        private void xoatrangKH()
        {
            txtHoKH.Text = ""; txtTenKH.Text = ""; txtCMND.Text = "";
            txtDiaChi.Text = ""; txtSDT.Text = "";
            dtpNgaySinh.Text = dtpNgaySinh.Value.ToString("1/1/1900");
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, cmnd, dc, sdt; DateTime ngaysinh;
            ma = txtMaKH.Text.Trim();
            ho = txtHoKH.Text.Trim();
            ten = txtTenKH.Text.Trim();
            ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
            cmnd = txtCMND.Text.Trim();
            dc = txtDiaChi.Text.Trim();
            sdt = txtSDT.Text.Trim();           

            DTOKhachHang kh = new DTOKhachHang(ma, ho, ten, ngaysinh, cmnd, dc, sdt);
            try
            {
                int i = new BUSKhachHang().Add(kh);
                dgvThemKH.DataSource = GetKH();
                load();
                dgvXoaKH.DataSource = GetKH();
                xoatrangKH();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE DSKhachHang Set Ho='" + txtHoKH.Text + "' ,Ten='" + txtTenKH.Text + "',NgaySinh='" + dtpNgaySinh.Text
                + "',CMND='" + txtCMND.Text + "',DiaChi='" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "'WHERE MaKH='" + txtMaKH.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvThemKH.DataSource = GetKH();
            xoatrangKH();
            cnn.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            xoatrangKH();    
        }

        private void dgvThemKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaKH.Text = dgvThemKH.Rows[dong].Cells[0].Value.ToString();
            this.txtHoKH.Text = dgvThemKH.Rows[dong].Cells[1].Value.ToString();
            this.txtTenKH.Text = dgvThemKH.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgaySinh.Text = dgvThemKH.Rows[dong].Cells[3].Value.ToString();
            this.txtCMND.Text = dgvThemKH.Rows[dong].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvThemKH.Rows[dong].Cells[5].Value.ToString();
            this.txtSDT.Text = dgvThemKH.Rows[dong].Cells[6].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "DELETE FROM DSKhachHang where MaKH='" + cbbMaKH.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvXoaKH.DataSource = GetKH();
            dgvThemKH.DataSource = GetKH();
            load();
            cnn.Close();
        }

        private void dgvXoaKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaKH.Text = dgvXoaKH.Rows[dong].Cells[0].Value.ToString();
        }

        private void FrmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
        }

       
      

     

              
    }
}
