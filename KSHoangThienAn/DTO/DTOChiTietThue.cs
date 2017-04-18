using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietThue
    {
        public string MaP { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime NgayTraDuKien { get; set; }
        public DateTime NgayTra { get; set; }
        public DTOChiTietThue(string mp, string mkh, DateTime nt, DateTime ndk, DateTime ntr)
        {
            MaP = mp; MaKH = mkh; NgayThue = nt; NgayTraDuKien = ndk; NgayTra = ntr;
        }
    }
}
