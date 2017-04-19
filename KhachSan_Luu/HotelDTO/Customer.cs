using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDTO
{
    public class Customer
    {
        public int MaKH { get; set; }
        public string HoKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public int CMND { get; set; }
        public int SDT { get; set; }
        public string GhiChu { get; set; }

        public Customer(int makh, string hokh, string tenkh, string gioitinh, int cmnd, int sdt, string ghichu)
        {
            MaKH = makh;
            HoKH = hokh;
            TenKH = tenkh;
            GioiTinh = gioitinh;
            CMND = cmnd;
            SDT = sdt;
            GhiChu = ghichu;
        }

        public Customer(string hokh, string tenkh, string gioitinh, int cmnd, int sdt, string ghichu)
        {
            HoKH = hokh;
            TenKH = tenkh;
            GioiTinh = gioitinh;
            CMND = cmnd;
            SDT = sdt;
            GhiChu = ghichu;
        }
    }
}
