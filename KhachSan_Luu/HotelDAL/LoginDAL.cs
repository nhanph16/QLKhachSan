using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDAL
{
    public class LoginDAL
    {
        private DataProvider dp;

        public LoginDAL()
        {
            dp = new DataProvider();
        }

        public int CheckLogin(int MaNV,string MK)
        {
            return dp.Login(MaNV, MK);
        }
    }
}
