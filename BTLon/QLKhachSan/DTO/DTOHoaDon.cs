using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayXuat { get; set; }
        public int ThanhTien { get; set; }
        public string MaNV { get; set; }
        public DTOHoaDon(string mh, string mk, DateTime nx, int tt, string mn)
        {
            MaHD = mh; MaKH = mk; NgayXuat = nx; ThanhTien = tt; MaNV = mn;
        }
    }
}
