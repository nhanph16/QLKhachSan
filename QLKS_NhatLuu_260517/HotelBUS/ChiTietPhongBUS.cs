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
    public class ChiTietPhongBUS
    {
        public List<HotelDTO.ChiTietPhong> GetChiTietPhong(string sql)
        {
            try
            {
                return new ChiTietPhongDAL().GetChiTietPhong(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int ExecQuery(string sql)
        {
            return new DataProvider().ExecNonQuery(sql);
        }
    }
}
