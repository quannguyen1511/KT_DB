using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        public List<Account> GetAccount()
        {
            try
            {
                return new AccountDAO().GetAccount();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
