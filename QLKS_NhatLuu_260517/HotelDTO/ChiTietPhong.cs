using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDTO
{
    public class ChiTietPhong
    {
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayDatPhong { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong { get; set; }
        public string LoaiHinhThue { get; set; }
        public int ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThaiPhong { get; set; }

        public ChiTietPhong(int MaNV, int MaKH, int MaPhong, DateTime NgayDatPhong, DateTime NgayNhanPhong, DateTime NgayTraPhong, string LoaiHinhThue, int ThanhTien, string GhiChu, bool TrangThaiPhong)
        {
            this.MaKH = MaKH;
            this.MaNV = MaNV;
            this.MaPhong = MaPhong;
            this.NgayDatPhong = NgayDatPhong;
            this.NgayNhanPhong = NgayNhanPhong;
            this.NgayTraPhong = NgayTraPhong;
            this.LoaiHinhThue = LoaiHinhThue;
            this.ThanhTien = ThanhTien;
            this.GhiChu = GhiChu;
            this.TrangThaiPhong = TrangThaiPhong;
        }
    }
}
