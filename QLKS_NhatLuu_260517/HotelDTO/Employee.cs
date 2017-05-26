using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDTO
{
    public class Employee
    {
        public int MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public int CMND { get; set; }
        public int SDT { get; set; }
        public string GhiChu { get; set; }

        public Employee(int manv, string honv, string tennv, string chucvu, int cmnd, int sdt, string ghichu)
        {
            MaNV = manv;
            HoNV = honv;
            TenNV = tennv;
            ChucVu = chucvu;
            CMND = cmnd;
            SDT = sdt;
            GhiChu = ghichu;
        }

        public Employee(string honv, string tennv, string chucvu, int cmnd, int sdt, string ghichu)
        {
            HoNV = honv;
            TenNV = tennv;
            ChucVu = chucvu;
            CMND = cmnd;
            SDT = sdt;
            GhiChu = ghichu;
        }
    }
}
