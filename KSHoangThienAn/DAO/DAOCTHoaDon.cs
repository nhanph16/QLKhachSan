using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DAOCTHoaDon
    {
        private DataProvider dp;
        public DAOCTHoaDon()
        {
            dp = new DataProvider();
        }
        public List<DTOCTHoaDon> GetCTHD(string sql)
        {
            dp.connect();
            List<DTOCTHoaDon> list = new List<DTOCTHoaDon>();
            {
                string m, ms;
                int sl, dg;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        m = dr.GetString(0);
                        ms = dr.GetString(1);
                        sl = dr.GetInt32(2);
                        dg = dr.GetInt32(3);
                        DTOCTHoaDon cthd = new DTOCTHoaDon(m, ms, sl, dg);
                        list.Add(cthd);
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
        public int Add(DTOCTHoaDon cthd)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@m", cthd.MaHD));
            paras.Add(new SqlParameter("@ms", cthd.MaSP));
            paras.Add(new SqlParameter("@sl", cthd.SoLuong));
            paras.Add(new SqlParameter("@dg", cthd.DonGia));
            try
            {
                return (dp.ExcuteNonQuery("ThemCTHD", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
