using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDTO;
using HotelBUS;
using System.Data.SqlClient;

namespace KhachSan
{
    public partial class FrmChiTietPhong : Form
    {
        public int MaNV;
        public FrmChiTietPhong()
        {
            InitializeComponent();
        }

        public FrmChiTietPhong(int manv)
        {
            MaNV = manv;
        }

        private List<ChiTietPhong> GetChiTietPhong()
        {
            string sql = "Select * From ChiTietPhong";
            return new ChiTietPhongBUS().GetChiTietPhong(sql);
        }

        private void LoadData()
        {
            try
            {
                dtgChi.DataSource = GetChiTietPhong();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmChiTietPhong_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = MaNV.ToString();
            LoadData();
        }
    }
}
