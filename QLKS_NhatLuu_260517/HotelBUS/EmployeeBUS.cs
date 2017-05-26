using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelDTO;
using System.Data.SqlClient;

namespace HotelBUS
{
    public class EmployeeBUS
    {
        public List<Employee> GetEmployee(string sql)
        {
            try
            {
                return new EmployeeDAL().GetEmployee(sql);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public int Add(Employee emp)
        {
            if (emp.HoNV == "" || emp.TenNV == "" || emp.ChucVu == "")
            {
                return -2;
            }

            try
            {
                return (new EmployeeDAL().Add(emp));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Delete(int MaNV)
        {
            if (MaNV == 0)
            {
                return -2;
            }
            try
            {
                return (new EmployeeDAL().Delete(MaNV));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Update(Employee emp)
        {
            if (emp.HoNV == "" || emp.TenNV == "" || emp.ChucVu == "" || emp.MaNV == 0)
            {
                return -2;
            }

            try
            {
                return (new EmployeeDAL().Update(emp));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
