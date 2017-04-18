using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;
namespace BUS
{
    public class BUSNhanVien
    {
        public List<DTONhanVien> GetNV(string sql)
        {
            return new DAONhanVien().GetNV(sql);
        }
        public int Add(DTONhanVien nv)
        {
            return (new DAONhanVien().Add(nv));
        }
    }
}
