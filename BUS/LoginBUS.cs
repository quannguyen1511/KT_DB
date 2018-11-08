using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
   public class LoginBUS
    {
        public bool login(string user, string pass)
        {
            LoginDAO lgd = new DAO.LoginDAO();
            return (lgd.login(user, pass));

        }
    }
}
