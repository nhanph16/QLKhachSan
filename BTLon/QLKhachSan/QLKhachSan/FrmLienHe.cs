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
    public partial class FrmLienHe : Form
    {
        public FrmLienHe()
        {
            InitializeComponent();
        }
        string str; SqlConnection cn;
        DataSet ds;
        private void FrmLienHe_Load(object sender, EventArgs e)
        {
            str = "server=. ; database =TrungTamKhoKS ;integrated security = true;";
            cn = new SqlConnection(str);
            string sql = "SELECT MaChuSoHuu,Ten,SoDienThoai,DiaChiNha FROM DSChuSoHuu ";
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
                dgvDSChuSoHuu.DataSource = ds.Tables[0];
                dgvDSChuSoHuu.Columns["DiaChiNha"].Width = 200;
            }
            catch (DataException ex)
            {

                MessageBox.Show("loi lien ket DL " + ex.ToString());
            }
        }

        private void dgvDSChuSoHuu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaChuSH.Text = dgvDSChuSoHuu.Rows[dong].Cells[0].Value.ToString();
            this.txtTenChuSH.Text = dgvDSChuSoHuu.Rows[dong].Cells[1].Value.ToString();
            this.txtSDTChuSH.Text = dgvDSChuSoHuu.Rows[dong].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgvDSChuSoHuu.Rows[dong].Cells[3].Value.ToString();            
        }
    }
}
