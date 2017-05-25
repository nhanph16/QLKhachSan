using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;
namespace BUS
{
    public class BUSHoaDon
    {
        public List<DTOHoaDon> GetHD(string sql)
        {
            return new DAOHoaDon().GetHD(sql);
        }
        public int Add(DTOHoaDon hd)
        {
            return new DAOHoaDon().Add(hd);
        }
    }
}
