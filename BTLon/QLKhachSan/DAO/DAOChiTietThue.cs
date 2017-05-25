using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DAOChiTietThue
    {
        private DataProvider dp;
        public DAOChiTietThue()
        {
            dp = new DataProvider();
        }
        public List<DTOChiTietThue> GetCTT(string sql)
        {
            dp.connect();
            List<DTOChiTietThue> list = new List<DTOChiTietThue>();
            {
                string map, makh;
                DateTime nt, ndk, ntr;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        map = dr.GetString(0);
                        makh = dr.GetString(1);
                        nt = dr.GetDateTime(2);
                        ndk = dr.GetDateTime(3);
                        ntr = dr.GetDateTime(4);
                        DTOChiTietThue ctt = new DTOChiTietThue(map, makh, nt, ndk, ntr);
                        list.Add(ctt);
                    }
                    dr.Close();
                    return list;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }
        public int Add(DTOChiTietThue ctt)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@map", ctt.MaP));
            paras.Add(new SqlParameter("@makh", ctt.MaKH));
            paras.Add(new SqlParameter("@nt", ctt.NgayThue));
            paras.Add(new SqlParameter("@ndk", ctt.NgayTraDuKien));
            paras.Add(new SqlParameter("@ntr", ctt.NgayTra));
            try
            {
                return (dp.ExcuteNonQuery("ThemCTT", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
