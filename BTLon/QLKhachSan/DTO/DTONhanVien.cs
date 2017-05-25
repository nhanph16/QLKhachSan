using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string BangCap { get; set; }

        public DTONhanVien(string ma, string h, string t, DateTime d, string gt, string cmnd, string sdt, string dc, string bc)
        {
            MaNV = ma; Ten = t; Ho = h; NgaySinh = d; GioiTinh = gt; CMND = cmnd; DiaChi = dc; BangCap = bc; SDT = sdt;
        }
    }
}
