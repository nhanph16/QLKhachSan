using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DAONhanVien
    {
        private DataProvider dp;
        public DAONhanVien()
        {
            dp = new DataProvider();
        }
        public List<DTONhanVien> GetNV(string sql)
        {
            dp.connect();
            List<DTONhanVien> list = new List<DTONhanVien>();
            {
                string ma, ho, ten, cmnd, dc, sdt, gt, bc;
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
                        gt = dr.GetString(4);
                        cmnd = dr.GetString(5);
                        dc = dr.GetString(7);
                        sdt = dr.GetString(6);
                        bc = dr.GetString(8);
                        DTONhanVien nv = new DTONhanVien(ma, ho, ten, ngaysinh, gt, cmnd, sdt, dc, bc);
                        list.Add(nv);
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
        public int Add(DTONhanVien nv)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@ma", nv.MaNV));
            paras.Add(new SqlParameter("@ho", nv.Ho));
            paras.Add(new SqlParameter("@ten", nv.Ten));
            paras.Add(new SqlParameter("@ngaysinh", nv.NgaySinh));
            paras.Add(new SqlParameter("@gt", nv.SDT));
            paras.Add(new SqlParameter("@cmnd", nv.CMND));
            paras.Add(new SqlParameter("@sdt", nv.SDT));
            paras.Add(new SqlParameter("@dc", nv.DiaChi));
            paras.Add(new SqlParameter("@bc", nv.BangCap));
            try
            {
                return (dp.ExcuteNonQuery("ThemNV", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
