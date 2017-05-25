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
    public partial class FrmChiTietThue : Form
    {
        public FrmChiTietThue()
        {
            InitializeComponent();
            //var a = this.PointToScreen(label6.Location);
            //a = pic1.PointToClient(a);
            //label6.Parent = pic1;
            //label6.Location = a;
            //label6.BackColor = Color.Transparent;
            //var c = this.PointToScreen(rdMaKH.Location);
            //c = pic1.PointToClient(c);
            //rdMaKH.Parent = pic1;
            //rdMaKH.Location = c;
            //rdMaKH.BackColor = Color.Transparent;
            //var b = this.PointToScreen(rdMaP.Location);
            //b = pic1.PointToClient(b);
            //rdMaP.Parent = pic1;
            //rdMaP.Location = b;
            //rdMaP.BackColor = Color.Transparent;
        }
        DataTable dtp,dtkh; string str; SqlConnection cn;
        DataSet ds;
        private void FrmChiTietThue_Load(object sender, EventArgs e)
        {
            str = "server =. ; database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
            load();
            dgvChiTietThue.DataSource = GetCTT();
            kiemtraghichu();
            this.rpvPhong.RefreshReport();
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
            // show bang phong cho chi thiet thue
            string sql = @"SELECT * FROM DSPhong";
            dtp = GetTable(sql);
            cbbMaP.DataSource = dtp;
            cbbMaP.DisplayMember = "MaP"; // cai minh hien khi nhap vao combobox
            cbbMaP.ValueMember = "MaP";


            // show bang khach hang cho chi tiet thue            
            sql = @"SELECT * FROM DSKhachHang";
            dtkh = GetTable(sql);
            cbbMaKH.DataSource = dtkh;
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";
        }
        public List<DTOChiTietThue> GetCTT()
        {
            string sql = "SELECT * FROM ChiTietThuePhong";
            return new BUSChiTietThue().GetCTT(sql);
        }

        //show bang ds phong vao datagridview
        public void kiemtraghichu()
        {
            string sql = "SELECT MaP,TinhTrang,GhiChu FROM DSPhong ";//where MaP='" + cbbMaP.Text + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                dgvDanhSachPhong.DataSource = ds.Tables[0];
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void btThemCTT_Click(object sender, EventArgs e)
        {
            string s="false";
            if (txtKiemTraGhiChu.Text == s.ToString())
            {
                MessageBox.Show("Phòng Đang Sửa , chưa sử dụng được!");
            }
            else
            {
                loadTinhTrangPhongThue();
                string map, makh;
                DateTime nt, ndk, ntr;
                map = cbbMaP.Text.Trim();
                makh = cbbMaKH.Text.Trim();
                nt = Convert.ToDateTime(dtpNgayThue.Text);
                ndk = Convert.ToDateTime(dtpNgayThue.Text);
                ntr = Convert.ToDateTime(dtpNgayThue.Text);
                DTOChiTietThue ctt = new DTOChiTietThue(map, makh, nt, ndk, ntr);
                try
                {
                    int i = new BUSChiTietThue().Add(ctt);
                    dgvChiTietThue.DataSource = GetCTT();
                    load();
                    loadChiTietGiaThem();
                    kiemtraghichu();
                    
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Bị Trùng!!" + ex.Message);
                }                
            }   
        }

        private void btSuaCTT_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE ChiTietThuePhong Set NgayTraDuKien='" + dtpNgayDuKien.Text
                + "',NgayTra='" + dtpNgayTra.Text + "'WHERE MaP='" + cbbMaP.Text + "'and  MaKH='" + cbbMaKH.Text + "' and NgayThue='" + dtpNgayThue.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvChiTietThue.DataSource = GetCTT();
            xoa();            
            cnn.Close();            
        }

        private void btXoaCTT_Click(object sender, EventArgs e)
        {
            loadTinhTrangPhongTrong();
            SqlConnection cn = new SqlConnection(str);
            string s = "DELETE FROM ChiTietThuePhong WHERE MaP='" + cbbMaP.Text + "'and MaKH='" + cbbMaKH.Text + "'and NgayThue='" +
                dtpNgayThue.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvChiTietThue.DataSource = GetCTT();
            load();            
            loadChiTietGiaXoa();            
            kiemtraghichu();
            xoa();
            
            cn.Close();
        }
        public void xoa()
        {
            cbbMaKH.Text = "";
            rdVip.Checked = true;
            dtpNgayDuKien.Text = dtpNgayDuKien.Value.ToString("1/1/1900 ");
            dtpNgayThue.Text = dtpNgayThue.Value.ToString("1/1/1900 ");
            dtpNgayTra.Text = dtpNgayTra.Value.ToString("1/1/1900 ");
        }
        private void btXoaTrang_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btTimKiemCTT_Click(object sender, EventArgs e)
        {
            if (rdMaP.Checked == true)
                loadMaP();
            else
                loadMaKH();
        } 
        public void loadMaP()
        {
            string sql = "SELECT * FROM ChiTietThuePhong WHERE MaP='" + txtTimKiem.Text + "'";
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
        public void loadMaKH()
        {
            string sql = "SELECT * FROM ChiTietThuePhong WHERE MaKH='" + txtTimKiem.Text + "'";
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

        private void dgvChiTietThue_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txtKiemTraGhiChu.Text = "";
            this.cbbMaKH.Text = dgvChiTietThue.Rows[dong].Cells[1].Value.ToString();
            this.cbbMaP.Text = dgvChiTietThue.Rows[dong].Cells[0].Value.ToString();
            this.dtpNgayThue.Text = dgvChiTietThue.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgayDuKien.Text = dgvChiTietThue.Rows[dong].Cells[3].Value.ToString();
            this.dtpNgayTra.Text = dgvChiTietThue.Rows[dong].Cells[4].Value.ToString();
            //kiemtraghichu();
        }


        // sau khi cho khach thue phong , thay doi tinh trang phong thanh da thue 
        // nhung phai thay doi no truoc khi them va truoc khi xoa vi no can cai ma phòng truyen vao
        public void loadTinhTrangPhongThue()
        {
            
            string s = "Đang Thuê";
            string sql = "UPDATE DSPhong Set TinhTrang='" + s.ToString()+ "'where MaP='"+cbbMaP.Text+"'";
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
        public void loadTinhTrangPhongTrong()
        {
            string s = "Đang Trông";
            string sql = "UPDATE DSPhong Set TinhTrang='" + s.ToString() + "'where MaP='" + cbbMaP.Text + "'";
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
        public void loadTinhTrangPhongSua()
        {
            string s = "Đang sưa chưa";
            string sql = "UPDATE DSPhong Set TinhTrang='" + s.ToString() + "'where MaP='" + cbbMaP.Text + "'";
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
        public void loadChiTietGiaThem()
        {
            if (rdVip.Checked == true)
            {
                string s = "VIP"; int p = 1;
                string sql = "UPDATE ChiTietGia Set SoPhongTrong= SoPhongTrong -'"+ p.ToString()+"'WHERE LoaiPhong='"+s.ToString()+"'";
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
            if (rdThuong.Checked == true)
            {
                string s = "Thuong"; int p = 1;
                string sql = "UPDATE ChiTietGia Set SoPhongTrong= SoPhongTrong -'" + p.ToString() + "'WHERE LoaiPhong='" + s.ToString() + "'";
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
        }
        public void loadChiTietGiaXoa()
        {
            if (rdVip.Checked == true)
            {
                string s = "VIP"; int p = 1;
                string sql = "UPDATE ChiTietGia Set SoPhongTrong= SoPhongTrong+'" + p.ToString() + "'WHERE LoaiPhong='" + s.ToString() + "'";
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
            if (rdThuong.Checked == true)
            {
                string s = "Thuong"; int p = 1;
                string sql = "UPDATE ChiTietGia Set SoPhongTrong= SoPhongTrong +'" + p.ToString() + "'WHERE LoaiPhong='" + s.ToString() + "'";
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

        }
        // khoa những phòng dag sua chua
        public void loadghichu()
        {
            string s = "false";
            string sql = "UPDATE DSPhong Set GhiChu='" + s.ToString() + "'where MaP='" + cbbMaP.Text + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                loadChiTietGiaThem();
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        public void loadNULL()
        {
            string s = "";
            string sql = "UPDATE DSPhong Set GhiChu='" + s.ToString() + "'where MaP='" + cbbMaP.Text + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                loadChiTietGiaXoa();
            }
            catch (DataException e)
            {

                MessageBox.Show("loi lien ket DL " + e.ToString());
            }
        }
        private void btClock_Click(object sender, EventArgs e)
        {
            loadghichu();
            loadTinhTrangPhongSua();
            kiemtraghichu();
            txtKiemTraGhiChu.Text = "false";
        }

        private void btUnClock_Click(object sender, EventArgs e)
        {
            loadTinhTrangPhongTrong();
            loadNULL();
            kiemtraghichu();
            txtKiemTraGhiChu.Text = "";
        }

        private void dgvDanhSachPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;            
            this.cbbMaP.Text = dgvDanhSachPhong.Rows[dong].Cells[0].Value.ToString();
            this.txtTinhTrang.Text = dgvDanhSachPhong.Rows[dong].Cells[1].Value.ToString();
            this.txtKiemTraGhiChu.Text = dgvDanhSachPhong.Rows[dong].Cells[2].Value.ToString();
            xoa();
        }
        // load lai bang trong trung tam
     


        // report
        public void loadreportCTT()
        {
            string sql = "SELECT * FROM ChiTietThuePhong";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbChiTietThue", dt); 
            rpvPhong.LocalReport.DataSources.Clear();
            rpvPhong.LocalReport.DataSources.Add(rds);
            rpvPhong.LocalReport.ReportPath = @"..\QLKhachSan\rptChiTietThue.rdlc";
            this.rpvPhong.RefreshReport();
        }
        public void loadreportDSphong()
        {
            string sql = "SELECT * FROM DSPhong";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbDSPhong", dt); 
            rpvPhong.LocalReport.DataSources.Clear();
            rpvPhong.LocalReport.DataSources.Add(rds);
            rpvPhong.LocalReport.ReportPath = @"..\QLKhachSan\rptDSPhong.rdlc";
            this.rpvPhong.RefreshReport();
        }
        public void loadreportCTGia()
        {
            string sql = "SELECT * FROM ChiTietGia";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("tbChiTietGia", dt); 
            rpvPhong.LocalReport.DataSources.Clear();
            rpvPhong.LocalReport.DataSources.Add(rds);
            rpvPhong.LocalReport.ReportPath = @"..\QLKhachSan\rptChiTietGia.rdlc";
            this.rpvPhong.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCTT.Checked == true)
                loadreportCTT();
            else if (rbCTG.Checked == true)
                loadreportCTGia();
            else
                loadreportDSphong();
        }

        // 
       

        private void FrmChiTietThue_FormClosed(object sender, FormClosedEventArgs e)
        {          
            FrmMain k = new FrmMain();
           k.Show();
           
        
        }

        private void btXemBangDSKhachSan_Click(object sender, EventArgs e)
        {
           
        }
      
        
       

    }
}
