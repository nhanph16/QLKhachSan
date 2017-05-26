using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDTO;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class EmployeeDAL
    {
        private DataProvider dp;

        public EmployeeDAL()
        {
            dp = new DataProvider();
        }

        public List<Employee> GetEmployee(string sql)
        {
            List<Employee> emp = new List<Employee>();
            int ma, cmnd, sdt;
            string ho, ten, chuc, ghichu;
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                while (dr.Read())
                {
                    ma = dr.GetInt32(0);
                    ho = dr.GetString(1);
                    ten = dr.GetString(2);
                    chuc = dr.GetString(3);
                    cmnd = dr.GetInt32(4);
                    sdt = dr.GetInt32(5);
                    ghichu = dr.GetString(6);
                    emp.Add(new Employee(ma, ho, ten, chuc, cmnd, sdt, ghichu));
                }
                return emp;
            }
            catch (SqlException ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }

        public int Add(Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@Ho", emp.HoNV));
            paras.Add(new SqlParameter("@Ten", emp.TenNV));
            paras.Add(new SqlParameter("@Chuc", emp.ChucVu));
            paras.Add(new SqlParameter("@CMND", emp.CMND));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@GhiChu", emp.GhiChu));
            SqlParameter para = new SqlParameter("@Ma", System.Data.SqlDbType.Int);
            para.Direction = System.Data.ParameterDirection.Output;
            paras.Add(para);

            try
            {
                return dp.ExecNonQuery("ThemNhanVien", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        /*public int Delete(int MaNV)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@Ma", MaNV);
            paras.Add(para);  
                return dp.ExecNonQuery("XoaNhanVien",System.Data.CommandType.StoredProcedure,paras);
        }*/
        public int Delete(int MaNV)
        {
            int kq;
            kq = dp.TimMa(MaNV, "NhanVien");
            string sql = "delete from NhanVien where MaNV = " + MaNV;
            if (kq != MaNV)
                return kq;
            else
            {
                kq = dp.ExecNonQuery(sql);
                if (kq != 0)
                    return kq;
                else
                    return MaNV;
            }
        }
        public int Update(Employee emp)
        {
            int kq;
            kq = dp.TimMa(emp.MaNV, "NhanVien");
            if (kq != emp.MaNV)
                return kq;
            string sql = "update NhanVien set HoNV = N'" + emp.HoNV + "' ,TenNV = N'" + emp.TenNV +
                "' ,ChucVu = N'" + emp.ChucVu + "' ,CMND = " + emp.CMND + " ,SDT = " + emp.SDT + 
                " ,GhiChu = N'" + emp.GhiChu + "' where MaNV = " + emp.MaNV;
            kq = dp.ExecNonQuery(sql);
            if (kq != 0)
                return kq;
            else
                return emp.MaNV;
        }
    }
}
