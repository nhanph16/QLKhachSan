using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
namespace BUS
{
    public class BUSChiTietThue
    {
        public List<DTOChiTietThue> GetCTT(string sql)
        {
            return new DAOChiTietThue().GetCTT(sql);
        }
        public int Add(DTOChiTietThue ctt)
        {
            return new DAOChiTietThue().Add(ctt);
        }
    }
}
