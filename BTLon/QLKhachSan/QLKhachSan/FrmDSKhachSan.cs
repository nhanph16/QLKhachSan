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

namespace QLKhachSan
{
    public partial class FrmDSKhachSan : Form
    {
        public FrmDSKhachSan()
        {            
            InitializeComponent();
        }
        SqlConnection cn; DataSet ds; string str1;
        private void FrmDSKhachSan_Load(object sender, EventArgs e)
        {
            // load danh sach ks con phong trong
            loadKSPhongTrong();
            loadKSKhongPhongTrong();
            updateTongSoPhong();            
           
        }
        public void loadKSPhongTrong()
        {
            str1 = "server =. ; database = TrungTamKhoKS ; Integrated Security = true;";
            cn = new SqlConnection(str1);
            int kt = 0;
            string sql = "SELECT * FROM DanhSachKhachSan WHERE SoPhongTrong !='" + kt.ToString() + "'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvDSPhongConTrong.DataSource = ds.Tables[0];
                
            }
            catch (DataException ex)
            {

                MessageBox.Show("loi lien ket DL " + ex.ToString());
            }
        }
        public void loadKSKhongPhongTrong()
        {

            str1 = "server =. ; database = TrungTamKhoKS ; Integrated Security = true;";
            cn = new SqlConnection(str1);
            int kt = 0;
            string sql = "SELECT * FROM DanhSachKhachSan WHERE SoPhongTrong='"+kt.ToString() +"'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvDSKhongPhongTrong.DataSource = ds.Tables[0];
            }
            catch (DataException ex)
            {

                MessageBox.Show("loi lien ket DL " + ex.ToString());
            }
        }

        private void dgvDSPhongConTrong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaKS.Text = dgvDSPhongConTrong.Rows[dong].Cells[1].Value.ToString();
            loadChiTiet();
        }
        public void loadChiTiet()
        {
            string ten = txtMaKS.Text;
            str1 = "server =. ; database ='"+ten.ToString()+"'; Integrated Security = true;";
            cn = new SqlConnection(str1);            
            string sql = "SELECT * FROM ChiTietGia";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvChiTietTungKS.DataSource = ds.Tables[0];
                dgvChiTietTungKS.Columns["GhiChu"].Width = 300;                
                tinhtongsophong();
            }
            catch (DataException ex)
            {

                MessageBox.Show("loi lien ket DL " + ex.ToString());
            }
        }
        public void updateTongSoPhong()
        {            
            str1 = "server =. ; database = TrungTamKhoKS; Integrated Security = true;";
            cn = new SqlConnection(str1);
            int a = int.Parse(txtTongSoPhong.Text);
            string sql = "UPDATE DanhSachKhachSan set SoPhongTrong='"+a.ToString()+"'where TenKS='"+txtMaKS.Text+"'";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);                
            }
            catch (DataException ex)
            {

                MessageBox.Show("loi lien ket DL " + ex.ToString());
            }
        }
        public void tinhtongsophong()
        {
            int tien = dgvChiTietTungKS.Rows.Count;
            float tongphong = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                tongphong += float.Parse(dgvChiTietTungKS.Rows[i].Cells["SoPhongTrong"].Value.ToString());
            }
            txtTongSoPhong.Text = tongphong.ToString();
        }

        private void FrmDSKhachSan_MouseLeave(object sender, EventArgs e)
        {
            FrmDSKhachSan_Load(sender, e);
        }

        private void FrmDSKhachSan_MouseClick(object sender, MouseEventArgs e)
        {
            //
        }

        private void FrmDSKhachSan_MouseUp(object sender, MouseEventArgs e)
        {
            //
        }

        private void FrmDSKhachSan_MouseDown(object sender, MouseEventArgs e)
        {
           // 
        }
    }
}
