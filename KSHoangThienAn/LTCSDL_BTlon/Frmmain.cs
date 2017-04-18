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

using BUS;
using DTO;
namespace LTCSDL_BTlon
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {            
            InitializeComponent();
        }        
        DataTable dtp, dtkh ,dtsp ,dthd ,dtnv;
        DataSet ds;
        string str = "";    
        private void Frmmain_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = GetKH();
            dgvNhanVien.DataSource = GetNV();
            dgvChiTietThue.DataSource = GetCTT();
            dgvCTHoaDon.DataSource = GetCTHD();
            dgvHoaDon.DataSource = GetHD();

            
            //dgvChiTiet.DataSource = GetCTHD2();
            str = "Server=. ; Database = KSHoangThienAn ; Integrated Security = true;";

            load();
           
        }
        public void load()
        {
            // show bang phong cho chi thiet thue
            string sql = @"SELECT * FROM DSPhong";
            dtp = GetTable(sql);
            cbbMaPhong.DataSource = dtp;
            cbbMaPhong.DisplayMember = "MaP"; // cai minh hien khi nhap vao combobox
            cbbMaPhong.ValueMember = "MaP";


            // show bang khach hang cho chi tiet thue            
            sql = @"SELECT * FROM DSKhachHang";
            dtkh = GetTable(sql);
            cbbMaKH.DataSource = dtkh;
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";

            cbbMaKHHD.DataSource = dtkh;
            cbbMaKHHD.DisplayMember = "MaKH";
            cbbMaKHHD.ValueMember = "MaKH";

            //show bang san pham cho chi tiet hoa don
            sql = @"SELECT * FROM SanPham";
            dtsp = GetTable(sql);
            cbbMaSP.DataSource = dtsp;
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.ValueMember = "MaSP";
            //DataView v = new DataView(TableUtils.getTableDisplayWrapper(dtsp, " ", "InvtDisplay", "MaSP", "Gia"));            //cbbMaSP.DataSource = v;

            //cbbMaSP.ValueMember = "Gia";

            //show bang HD cho chi tiet hoa don
            sql = @"SELECT * FROM HoaDon";
            dthd = GetTable(sql);
            cbbMaHD.DataSource = dthd;
            cbbMaHD.DisplayMember = "MaHD";
            cbbMaHD.ValueMember = "MaHD";

            //
            sql = @"SELECT * FROM  CTHoaDon ";
            dthd = GetTable(sql);
            dgvChiTiet.DataSource = dthd;

            //ds nhan vien
            sql = @"SELECT * FROM NhanVien";
            dtnv = GetTable(sql);
            cbbMaNV.DataSource = dtnv;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }
        // class ho tro de hien 2 file tren 1 combbbox
        class TableUtils
        {
            /// <summary>
            /// Get wrapper table for displaying purpose!
            /// </summary>
            /// <param name="core">Original table</param>
            /// <param name="seperateString">A string for seperating members you want to display</param>
            /// <param name="diplayMember">A name for display member</param>
            /// <param name="args">Input members for creating display member</param>
            /// <returns>Display wrapper of input table</returns>
            public static DataTable getTableDisplayWrapper(DataTable core, string seperateString, string diplayMember, params string[] args)
            {
                DataTable wrapper = new DataTable();
                // Make new display column 
                wrapper.Columns.Add(new DataColumn(diplayMember, Type.GetType("System.String")));
                // Copy columns from original table
                foreach (DataColumn columnCore in core.Columns)
                {
                    wrapper.Columns.Add(new DataColumn(columnCore.ColumnName, columnCore.DataType));
                }
                // Copy rows from original table with a new display cell for each row
                foreach (DataRow rowCore in core.Rows)
                {
                    DataRow rowWrapper = wrapper.NewRow();
                    string displayCell = "";
                    // Create display cell
                    foreach (string arg in args)
                    {
                        try
                        {
                            displayCell += rowCore[arg] + seperateString;
                        }
                        catch (ArgumentException)
                        {
                            throw new Exception("Invalid data field");
                        }
                    }
                    displayCell = displayCell.Remove(displayCell.Length - seperateString.Length);
                    rowWrapper[diplayMember] = displayCell;
                    // Copy cells from original row
                    foreach (DataColumn columnCore in core.Columns)
                    {
                        // Avoid to make a shallow copy
                        rowWrapper[columnCore.ColumnName] = rowCore[columnCore].ToString();
                    }
                    wrapper.Rows.Add(rowWrapper);
                }
                return wrapper;
            }

        }
       
        // ham ho tro cho viet show combobox
        private DataTable GetTable(string sql)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Khach Hang ------------------
       private void xoatrangKH()
       {           
            txtHo.Text = ""; txtTen.Text = ""; txtCMND.Text = "";
            txtDiaChi.Text = ""; txtSDT.Text = "";
            dtpNgaySinh.Text = dtpNgaySinh.Value.ToString("1/1/1900"); 
       }
        public List<DTOKhachHang> GetKH()
        {
            string sql = "SELECT * FROM DSKhachHang";
            return new BUSKhachHang().GetKH(sql);            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, cmnd, dc, sdt, fax; DateTime ngaysinh;
            ma = txtMaKH.Text.Trim();
            ho = txtHo.Text.Trim();
            ten = txtTen.Text.Trim();
            ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);           
            cmnd = txtCMND.Text.Trim();
            dc = txtDiaChi.Text.Trim();
            sdt = txtSDT.Text.Trim();
            fax = txtFax.Text.Trim();

            DTOKhachHang kh = new DTOKhachHang(ma, ho, ten, ngaysinh, cmnd, dc, sdt);
            try
            {
                int i = new BUSKhachHang().Add(kh);
                dgvKhachHang.DataSource = GetKH();
                load();
                xoatrangKH();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "DELETE FROM DSKhachHang where MaKH='" + txtMaKH.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s,cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvKhachHang.DataSource = GetKH();
            load();
            cnn.Close();

        }

        //khi lick vao 1 trong cac o cua 1 dong nó sẽ show lên textbox
        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            //manv = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtMaKH.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            this.txtHo.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
            this.txtTen.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgaySinh.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString();
            this.txtCMND.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[5].Value.ToString();
            this.txtSDT.Text = dgvKhachHang.Rows[dong].Cells[6].Value.ToString();
            //this.txtFax.Text = dgvKhachHang.Rows[dong].Cells[7].Value.ToString();           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE DSKhachHang Set Ho='" + txtHo.Text + "' ,Ten='" + txtTen.Text + "',NgaySinh='" + dtpNgaySinh.Text
                + "',CMND='" + txtCMND.Text + "',DiaChi='" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "'WHERE MaKH='"+txtMaKH.Text+"'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvKhachHang.DataSource = GetKH();
            cnn.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            xoatrangKH();    
        }

      

       // Ket thuc khach hang -------------------------------------------


       // bat dau Nhan Vien
        public List<DTONhanVien> GetNV()        {
            
            string sql = "SELECT * FROM NhanVien";
            return new BUSNhanVien().GetNV(sql);
        }

        private void btXoanv_Click(object sender, EventArgs e)
        {
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

        private void XoaNV()
        {
            txtTennv.Text = ""; txtSDTnv.Text = "";
            txtGioiTinh.Text = ""; txtDiaChinv.Text = "";
            dtpNgaySinhnv.Text = dtpNgaySinhnv.Value.ToString("1/1/1900");
            txtBangCap.Text = ""; txtCMNDnv.Text = "";
        }
        private void btResetNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = ""; txtHonv.Text = "";
            XoaNV();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;           
            this.txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            this.txtHonv.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            this.txtTennv.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgaySinhnv.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
            this.txtGioiTinh.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
            this.txtCMNDnv.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            this.txtSDTnv.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            this.txtDiaChinv.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
            this.txtBangCap.Text = dgvNhanVien.Rows[dong].Cells[8].Value.ToString(); 
        }

        private void btThemnv_Click(object sender, EventArgs e)
        {
            string ma, ho, ten, cmnd, dc, sdt,gt,bc; DateTime ngaysinh;
            ma = txtMaNV.Text.Trim();
            ho = txtHonv.Text.Trim();
            ten = txtTennv.Text.Trim();
            ngaysinh = Convert.ToDateTime(dtpNgaySinhnv.Text);
            cmnd = txtCMNDnv.Text.Trim();
            sdt = txtSDTnv.Text.Trim();
            dc = txtDiaChinv.Text.Trim();            
            gt = txtGioiTinh.Text.Trim();
            bc = txtBangCap.Text.Trim();

            DTONhanVien nv = new DTONhanVien(ma, ho, ten, ngaysinh,gt ,cmnd, sdt, dc,bc);
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
        }

        private void btSuanv_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE NhanVien Set Ho='" + txtHonv.Text + "' ,Ten='" + txtTennv.Text + "',NgaySinh='" + dtpNgaySinhnv.Text
                + "',CMND='" + txtCMNDnv.Text + "',DiaChi='" + txtDiaChinv.Text + "',SDT='" + txtSDTnv.Text 
                + "',GioiTinh='" + txtGioiTinh.Text + "',BangCap='" + txtBangCap.Text + "'WHERE MaNV='" + txtMaNV.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvNhanVien.DataSource = GetNV();
            cnn.Close();
        }


        // ket thuc cua nhan vien


        //bat dau chi tiet thue
        public List<DTOChiTietThue>GetCTT()
        {
            string sql = "SELECT * FROM ChiTietThuePhong";
            return new BUSChiTietThue().GetCTT(sql);
        }     

        private void btXoahetCTT_Click(object sender, EventArgs e)
        {
            cbbMaKH.Text = "";
            xoaCTT();
        }
        private void xoaCTT()
        {
            cbbMaPhong.Text = "";
            //txtNgayTra.Text = "";
            //txtNgayThue.Text = "";
            //txtNgayDuKien.Text = "";
            dtpNgayDuKien.Text = dtpNgayDuKien.Value.ToString("1/1/1900 ");
            dtpNgayThue.Text = dtpNgayThue.Value.ToString("1/1/1900 ");
            dtpNgayTra.Text = dtpNgayTra.Value.ToString("1/1/1900 ");
        }
        private void btThemCTT_Click(object sender, EventArgs e)
        {

            string map, makh;
            DateTime nt, ndk, ntr;
            map = cbbMaPhong.Text.Trim();
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
                xoaCTT();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btSuaCTT_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            string s = "UPDATE ChiTietThuePhong Set NgayTraDuKien='" + dtpNgayDuKien.Text
                + "',NgayTra='" + dtpNgayTra.Text + "'WHERE MaP='" + cbbMaPhong.Text + "'and  MaKH='" + cbbMaKH.Text + "' and NgayThue='" + dtpNgayThue.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvChiTietThue.DataSource = GetCTT();
            cnn.Close();
        }
        private void btXoaCTT_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "DELETE FROM ChiTietThuePhong WHERE MaP='" + cbbMaPhong.Text + "'and MaKH='" + cbbMaKH.Text + "'and NgayTra='" +
                dtpNgayThue.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvChiTietThue.DataSource = GetCTT();
            load();
            cn.Close();
        }
        private void dgvChiTietThue_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaPhong.Text = dgvChiTietThue.Rows[dong].Cells[0].Value.ToString();
            this.cbbMaKH.Text = dgvChiTietThue.Rows[dong].Cells[1].Value.ToString();
            this.dtpNgayThue.Text = dgvChiTietThue.Rows[dong].Cells[2].Value.ToString();
            this.dtpNgayDuKien.Text = dgvChiTietThue.Rows[dong].Cells[3].Value.ToString();
            this.dtpNgayTra.Text = dgvChiTietThue.Rows[dong].Cells[4].Value.ToString();
        }
        // ket thuc chi tiet thue


        // bat dau chi tiet hoa don
        public List<DTOCTHoaDon> GetCTHD()
        {
            string sql = "SELECT * FROM CTHoaDon";
            return new BUSCTHoaDon().GetCTHD(sql);
        }       

        private void btThemCTHD_Click(object sender, EventArgs e)
        {
            string m, ms;
            int sl, dg;
            m = cbbMaHD.Text.Trim();
            ms = cbbMaSP.Text.Trim();
            sl = int.Parse( txtSoLuong.Text);
            dg = int.Parse(txtGia.Text);
            DTOCTHoaDon cthd = new DTOCTHoaDon(m, ms, sl, dg);
            try
            {
                int i = new BUSCTHoaDon().Add(cthd);
                dgvCTHoaDon.DataSource = GetCTHD();
                load();
                xoaCTHD();
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
            txtGia.Text = "";
        }

        private void btxoazz_Click(object sender, EventArgs e)
        {
            cbbMaHD.Text = "";
            xoaCTHD();
        }

        private void btXoaCTHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "DELETE FROM CTHoaDon WHERE MaHD='" + cbbMaHD.Text + "' and MaSP='" + cbbMaSP.Text + "'"; 
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvCTHoaDon.DataSource = GetCTHD();
            load();
            cn.Close();
        }

        private void btSuaCTHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "UPDATE CTHoaDon SET SoLuong='"+txtSoLuong.Text+"',DonGia='"+txtGia.Text 
            +"'WHERE MaHD='" + cbbMaHD.Text + "' and MaSP='" +cbbMaSP.Text+"'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvCTHoaDon.DataSource = GetCTHD();
            cn.Close();
        }

        private void dgvCTHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.cbbMaHD.Text = dgvCTHoaDon.Rows[dong].Cells[0].Value.ToString();
            this.cbbMaSP.Text = dgvCTHoaDon.Rows[dong].Cells[1].Value.ToString();
            this.txtSoLuong.Text = dgvCTHoaDon.Rows[dong].Cells[2].Value.ToString();
            this.txtGia.Text = dgvCTHoaDon.Rows[dong].Cells[3].Value.ToString();           
        }

      
        // ket thuc chi tiet hoa don




        // bat dau bang hoa don
        public List<DTOHoaDon> GetHD()
        {
            string sql = "SELECT * FROM HoaDon";
            return new BUSHoaDon().GetHD(sql);
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaHD.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();
            this.cbbMaKHHD.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString();
            this.dtpNgayXuat.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
            this.txtThanhTien.Text = dgvHoaDon.Rows[dong].Cells[3].Value.ToString();
            this.cbbMaNV.Text = dgvHoaDon.Rows[dong].Cells[4].Value.ToString();     
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            string mh, mk, mv; DateTime nx; int tt;
            mh = txtMaHD.Text.Trim();
            mk = cbbMaKHHD.Text.Trim();
            nx = Convert.ToDateTime(dtpNgayXuat.Text);
            tt = int.Parse(txtThanhTien.Text);
            mv = cbbMaNV.Text.Trim();

            DTOHoaDon hd = new DTOHoaDon(mh, mk, nx, tt, mv);
            try
            {
                int i = new BUSHoaDon().Add(hd);
                dgvHoaDon.DataSource = GetHD();
                load();
                xoatrangHD();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void xoatrangHD()
        {
            cbbMaKHHD.Text = "";
            dtpNgayXuat.Text = dtpNgayXuat.Value.ToString("1/1/1900");
            txtThanhTien.Text = "";
            cbbMaNV.Text = "";
        }

        private void btXoaHetHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            xoatrangHD();
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
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

        private void btSuaHD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            string s = "UPDATE HoaDon SET MaKH='" + cbbMaKHHD.Text + "',NgayXuat='" + dtpNgayXuat.Text + "',ThanhTien='" + txtThanhTien.Text
            +"',MaNV='"+cbbMaNV.Text+ "'WHERE MaHD='" + txtMaHD.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvHoaDon.DataSource = GetHD();
            cn.Close();
        }

        

        
        //public void load2()
        //{
        //    SqlConnection cnn = new SqlConnection(str);
        //    string s = "SELECT * FROM  CTHoaDon WHERE MaHD='" + txtMaHD.Text +"'";
        //    cnn.Open();
        //    SqlCommand cmd = new SqlCommand(s, cnn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.ExecuteNonQuery();
        //    dgvKhachHang.DataSource = GetKH();
        //    cnn.Close();
        //}
      
        
     
        

       

        

       

       

        

       

       

        
        
    }
}
