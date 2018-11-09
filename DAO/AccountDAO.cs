using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class AccountDAO: DataProvider
    {
        public List<Account> GetAccount()
        {
            string sql = "SELECT * FROM Account";
            connect();
            try
            {
                SqlDataReader dr = mysqlDataReader(sql);
                string id, username, password, displayname;
                int countday, countmonth;
                List<Account> list = new List<Account>();
                while(dr.Read())
                {
                    id= dr[0].ToString();
                    username = dr[1].ToString();
                    password = dr[2].ToString();
                    displayname = dr[3].ToString();
                    countday = Convert.ToInt16(dr[4]);
                    countmonth = Convert.ToInt16(dr[5]);
                    Account account = new Account(id, username, password, displayname, countday, countmonth);
                    list.Add(account);
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                disconnect();
            }
        }
      }
}
