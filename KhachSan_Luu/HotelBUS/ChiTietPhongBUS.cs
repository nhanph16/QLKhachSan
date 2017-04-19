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
        public List<ChiTietPhong> GetChiTietPhong(string sql)
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

        /*public int Add(ChiTietPhong chi)
        {
            if (chi.HoKH == "" || chi.TenKH == "" || chi.GioiTinh == "")
            {
                return -2;
            }

            try
            {
                return (new ChiTietPhongDAL().Add(chi));
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
                return (new ChiTietPhongDAL().Delete(MaKH));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Update(ChiTietPhong chi)
        {
            if (chi.HoKH == "" || chi.TenKH == "" || chi.GioiTinh == "" || chi.MaKH == 0)
            {
                return -2;
            }

            try
            {
                return (new ChiTietPhongDAL().Update(chi));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }*/
    }
}
