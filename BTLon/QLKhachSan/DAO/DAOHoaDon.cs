using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DAOHoaDon
    {
        private DataProvider dp;
        public DAOHoaDon()
        {
            dp = new DataProvider();
        }
        public List<DTOHoaDon> GetHD(string sql)
        {
            dp.connect();
            List<DTOHoaDon> list = new List<DTOHoaDon>();
            {
                string mh, mk, mn;
                DateTime nx; int tt;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        mh = dr.GetString(0);
                        mk = dr.GetString(1);
                        nx = dr.GetDateTime(2);
                        tt = dr.GetInt32(3);
                        mn = dr.GetString(4);

                        DTOHoaDon hd = new DTOHoaDon(mh, mk, nx, tt, mn);
                        list.Add(hd);
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
        public int Add(DTOHoaDon hd)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@mh", hd.MaHD));
            paras.Add(new SqlParameter("@mk", hd.MaKH));
            paras.Add(new SqlParameter("@nx", hd.NgayXuat));
            paras.Add(new SqlParameter("@tt", hd.ThanhTien));
            paras.Add(new SqlParameter("@mv", hd.MaNV));
            try
            {
                return (dp.ExcuteNonQuery("ThemHD", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
