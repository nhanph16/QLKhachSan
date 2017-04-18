using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCTHoaDon
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public DTOCTHoaDon(string m, string ms, int sl, int dg)
        {
            MaHD = m; MaSP = ms; SoLuong = sl; DonGia = dg;
        }
    }
}
