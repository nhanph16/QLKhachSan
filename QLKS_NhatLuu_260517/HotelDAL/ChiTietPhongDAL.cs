using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDTO;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class ChiTietPhongDAL
    {
        private DataProvider dp;

        public ChiTietPhongDAL()
        {
            dp = new DataProvider();
        }

        public List<HotelDTO.ChiTietPhong> GetChiTietPhong(string sql)
        {
            List<HotelDTO.ChiTietPhong> chi = new List<HotelDTO.ChiTietPhong>();
            int MaNV, MaKH, MaPhong, ThanhTien;
            string LoaiHinhThue, GhiChu;
            bool TrangThaiPhong;
            DateTime NgayDatPhong, NgayNhanPhong, NgayTraPhong;

            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                while (dr.Read())
                {
                    MaNV = dr.GetInt32(0);
                    MaKH = dr.GetInt32(1);
                    MaPhong = dr.GetInt32(2);
                    NgayDatPhong = dr.GetDateTime(3);
                    NgayNhanPhong = dr.GetDateTime(4);
                    NgayTraPhong = dr.GetDateTime(5);
                    LoaiHinhThue = dr.GetString(6);
                    ThanhTien = dr.GetInt32(7);
                    GhiChu = dr.GetString(8);
                    TrangThaiPhong = dr.GetBoolean(9);
                    chi.Add(new HotelDTO.ChiTietPhong(MaNV,MaKH,MaPhong,NgayDatPhong,NgayNhanPhong,NgayTraPhong,LoaiHinhThue,ThanhTien,GhiChu,TrangThaiPhong));
                }
                return chi;
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

        public int Add(string sql)
        {
            return dp.ExecNonQuery(sql);
        }

        /*public int Delete(int MaKH)
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

        public int Update(ChiTietPhong chi)
        {
            int kq;
            kq = dp.TimMa(chi.MaKH, "KhachHang");
            if (kq != chi.MaKH)
                return kq;
            string sql = "update KhachHang set HoKH = N'" + chi.HoKH + "' ,TenKH = N'" + chi.TenKH +
                "' ,GioiTinh = N'" + chi.GioiTinh + "' ,CMND = " + chi.CMND + " ,SDT = " + chi.SDT +
                " ,GhiChu = N'" + chi.GhiChu + "' where MaKH = " + chi.MaKH;
            kq = dp.ExecNonQuery(sql);
            if (kq != 0)
                return kq;
            else
                return chi.MaKH;
        }*/
    }
}
