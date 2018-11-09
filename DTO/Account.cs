using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string DisplayName { get; set; }
        public int CountDay { get; set; }
        public int CountMonth { get; set; }

        public Account(string id, string username, string password, string displayname, int countday, int countmonth)
        {
            this.Id = id;
            this.UserName = username;
            this.PassWord = password;
            this.DisplayName = displayname;
            this.CountDay =countday;
            this.CountMonth = countmonth;
        }
    }
}
