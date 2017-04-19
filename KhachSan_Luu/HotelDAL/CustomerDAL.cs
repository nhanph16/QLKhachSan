using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDTO;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class CustomerDAL
    {
        private DataProvider dp;

        public CustomerDAL()
        {
            dp = new DataProvider();
        }

        public List<Customer> GetCustomer(string sql)
        {
            List<Customer> cus = new List<Customer>();
            int ma, cmnd, sdt;
            string ho, ten, gioitinh, ghichu;
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                while (dr.Read())
                {
                    ma = dr.GetInt32(0);
                    ho = dr.GetString(1);
                    ten = dr.GetString(2);
                    gioitinh = dr.GetString(3);
                    cmnd = dr.GetInt32(4);
                    sdt = dr.GetInt32(5);
                    ghichu = dr.GetString(6);
                    cus.Add(new Customer(ma, ho, ten, gioitinh, cmnd, sdt, ghichu));
                }
                return cus;
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

        public int Add(Customer cus)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@Ho", cus.HoKH));
            paras.Add(new SqlParameter("@Ten", cus.TenKH));
            paras.Add(new SqlParameter("@GioiTinh", cus.GioiTinh));
            paras.Add(new SqlParameter("@CMND", cus.CMND));
            paras.Add(new SqlParameter("@SDT", cus.SDT));
            paras.Add(new SqlParameter("@GhiChu", cus.GhiChu));
            SqlParameter para = new SqlParameter("@Ma", System.Data.SqlDbType.Int);
            para.Direction = System.Data.ParameterDirection.Output;
            paras.Add(para);

            try
            {
                return dp.ExecNonQuery("ThemKhachHang", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public int Delete(int MaKH)
        {
            int kq;
            kq = dp.TimMa(MaKH, "KhachHang");
            string sql = "delete from KhachHang where MaKH = " + MaKH;
            if (kq != MaKH)
                return kq;
            else
            {
                kq = dp.ExecNonQuery(sql);
                if (kq != 0)
                    return kq;
                else
                    return MaKH;
            }
        }

        public int Update(Customer cus)
        {
            int kq;
            kq = dp.TimMa(cus.MaKH, "KhachHang");
            if (kq != cus.MaKH)
                return kq;
            string sql = "update KhachHang set HoKH = N'" + cus.HoKH + "' ,TenKH = N'" + cus.TenKH +
                "' ,GioiTinh = N'" + cus.GioiTinh + "' ,CMND = " + cus.CMND + " ,SDT = " + cus.SDT +
                " ,GhiChu = N'" + cus.GhiChu + "' where MaKH = " + cus.MaKH;
            kq = dp.ExecNonQuery(sql);
            if (kq != 0)
                return kq;
            else
                return cus.MaKH;
        }
    }
}
