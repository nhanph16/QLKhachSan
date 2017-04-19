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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private List<Employee> GetEmployee()
        {
            string sql = "Select * From NhanVien";
            return new EmployeeBUS().GetEmployee(sql);
        }

        private void LoadData()
        {
            try
            {
                dtgEmp.DataSource = GetEmployee();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaNV.DataBindings.Add("Text", dtgEmp.DataSource, "MaNV");
            txtHoNV.DataBindings.Add("Text", dtgEmp.DataSource, "HoNV");
            txtTenNV.DataBindings.Add("Text", dtgEmp.DataSource, "TenNV");
            txtChucNV.DataBindings.Add("Text", dtgEmp.DataSource, "ChucVu");
            txtSDTNV.DataBindings.Add("Text", dtgEmp.DataSource, "SDT");
            txtCMNDNV.DataBindings.Add("Text", dtgEmp.DataSource, "CMND");
            txtGhiChu.DataBindings.Add("Text", dtgEmp.DataSource, "GhiChu");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int CMND = 0, SDT = 0;
            string HoNV = "", TenNV = "", ChucVu = "", GhiChu = "";

            HoNV = txtHoNV.Text.Trim();
            TenNV = txtTenNV.Text.Trim();
            ChucVu = txtChucNV.Text.Trim();
            GhiChu = txtGhiChu.Text.Trim();
            
            try
            {
                CMND = int.Parse(txtCMNDNV.Text);
                SDT = int.Parse(txtSDTNV.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("CMND hoặc SDT chưa nhập hoặc không hợp lệ, nếu thêm thành công mặc định giá trị này bằng 0");
            }

            Employee emp = new Employee(HoNV, TenNV, ChucVu,CMND, SDT, GhiChu);
            try
            {
                int i = new EmployeeBUS().Add(emp);
                switch (i)
                {
                    case -1:
                        MessageBox.Show("Lỗi, không thể thêm dữ liệu");
                        break;
                    case -2:
                        MessageBox.Show("Phải nhập đầy đủ họ, tên và chức vụ");
                        break;
                    default:
                        MessageBox.Show("Đã thêm một nhân viên ở mã " + i);
                        break;
                }
                LoadData();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int MaNV;
            if (txtMaNV.Text == "")
                MaNV = 0;
            else
                MaNV = int.Parse(txtMaNV.Text);
            try
            {
                int i = new EmployeeBUS().Delete(MaNV);
                switch (i)
                {
                    case -1:
                        MessageBox.Show("Lỗi, không thể xóa dữ liệu");
                        break;
                    case -2:
                        MessageBox.Show("Phải nhập mã để xóa");
                        break;
                    case -6:
                        MessageBox.Show("Không tìm thấy mã để xóa");
                        break;
                    default:
                        MessageBox.Show("Đã xóa một nhân viên ở mã " + i);
                        break;
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            int MaNV = 0, CMND = 0, SDT = 0;
            string HoNV = "", TenNV = "", ChucVu = "", GhiChu = "Đã sửa";

            HoNV = txtHoNV.Text.Trim();
            TenNV = txtTenNV.Text.Trim();
            ChucVu = txtChucNV.Text.Trim();
            GhiChu = txtGhiChu.Text.Trim();

            try
            {
                MaNV = int.Parse(txtMaNV.Text);
                CMND = int.Parse(txtCMNDNV.Text);
                SDT = int.Parse(txtSDTNV.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã nhân viên hoặc CMND hoặc SDT chưa nhập hoặc không hợp lệ, nếu sửa thành công mặc định giá trị này bằng 0");
            }

            Employee emp = new Employee(MaNV, HoNV, TenNV, ChucVu, CMND, SDT, GhiChu);
            try
            {
                int i = new EmployeeBUS().Update(emp);
                switch (i)
                {
                    case -1:
                        MessageBox.Show("Lỗi, không thể sửa dữ liệu");
                        break;
                    case -2:
                        MessageBox.Show("Phải nhập đầy đủ mã, họ, tên và chức vụ");
                        break;
                    case -6:
                        MessageBox.Show("Không tìm thấy mã để sửa");
                        break;
                    default:
                        MessageBox.Show("Đã sửa một nhân viên ở mã " + i);
                        break;
                }
                LoadData();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
