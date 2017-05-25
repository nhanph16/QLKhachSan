using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;
namespace BUS
{
    public class BUSKhachHang
    {
        public List<DTOKhachHang> GetKH(string sql)
        {
            return new DAOKhachHang().GetKH(sql);
        }
        public int Add(DTOKhachHang kh)
        {
            return (new DAOKhachHang().Add(kh));
        }
    }
}
