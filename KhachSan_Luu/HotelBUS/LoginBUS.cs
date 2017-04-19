using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;

namespace HotelBUS
{
    public class LoginBUS
    {
        public int CheckLogin(int MaNV, string MK)
        {
            return new HotelDAL.LoginDAL().CheckLogin(MaNV, MK);
        }
    }
}
