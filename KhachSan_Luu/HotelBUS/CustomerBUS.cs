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
    public class CustomerBUS
    {
        public List<Customer> GetCustomer(string sql)
        {
            try
            {
                return new CustomerDAL().GetCustomer(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Add(Customer cus)
        {
            if (cus.HoKH == "" || cus.TenKH == "" || cus.GioiTinh == "")
            {
                return -2;
            }

            try
            {
                return (new CustomerDAL().Add(cus));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Delete(int MaKH)
        {
            if (MaKH == 0)
            {
                return -2;
            }
            try
            {
                return (new CustomerDAL().Delete(MaKH));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Update(Customer cus)
        {
            if (cus.HoKH == "" || cus.TenKH == "" || cus.GioiTinh == "" || cus.MaKH == 0)
            {
                return -2;
            }

            try
            {
                return (new CustomerDAL().Update(cus));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
