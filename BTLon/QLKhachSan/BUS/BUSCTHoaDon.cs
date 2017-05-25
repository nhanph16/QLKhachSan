using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
namespace BUS
{
    public class BUSCTHoaDon
    {
        public List<DTOCTHoaDon> GetCTHD(string sql)
        {
            return new DAOCTHoaDon().GetCTHD(sql);
        }
        public int Add(DTOCTHoaDon cthd)
        {
            return (new DAOCTHoaDon().Add(cthd));
        }
    }
}
