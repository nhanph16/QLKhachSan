using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DAOKhachHang
    {
        private DataProvider dp;
        public DAOKhachHang()
        {
            dp = new DataProvider();
        }
        public List<DTOKhachHang> GetKH(string sql)
        {
            dp.connect();
            List<DTOKhachHang> list = new List<DTOKhachHang>();
            {
                string ma, ho, ten, cmnd, dc, sdt;
                DateTime ngaysinh;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        ma = dr.GetString(0);
                        ho = dr.GetString(1);
                        ten = dr.GetString(2);
                        ngaysinh = dr.GetDateTime(3);
                        cmnd = dr.GetString(4);
                        dc = dr.GetString(5);
                        sdt = dr.GetString(6);
                        //fax = dr.GetString(7);
                        DTOKhachHang kh = new DTOKhachHang(ma, ho, ten, ngaysinh, cmnd, dc, sdt);
                        list.Add(kh);
                    }
                    dr.Close();
                    return list;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
                finally { dp.disconnect(); }
            }
        }
        public int Add(DTOKhachHang kh)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@ma", kh.MaKH));
            paras.Add(new SqlParameter("@ho", kh.Ho));
            paras.Add(new SqlParameter("@ten", kh.Ten));
            paras.Add(new SqlParameter("@ngaysinh", kh.NgaySinh));
            paras.Add(new SqlParameter("@cmnd", kh.CMND));
            paras.Add(new SqlParameter("@dc", kh.DiaChi));
            paras.Add(new SqlParameter("@sdt", kh.SDT));
            try
            {
                return (dp.ExcuteNonQuery("ThemKH", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
