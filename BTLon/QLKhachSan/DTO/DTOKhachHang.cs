using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOKhachHang
    {
        public string MaKH { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Fax { get; set; }
        public DTOKhachHang(string m, string h, string t, DateTime ns, string cmnd, string dc, string sdt)
        {
            MaKH = m; Ho = h; Ten = t; CMND = cmnd; DiaChi = dc; SDT = sdt; NgaySinh = ns;
        }
    }
}
