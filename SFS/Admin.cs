using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Admin
    {
         string userName;
         string userPassword;
        public Admin(string username, string userpassword)
        {
            userName = username;
            userPassword = userpassword;
        }
        public Admin()
        {
            userName = "";
            userPassword = "";
        }
        public void setuserName(string userName)
        {
            this.userName = userName;

        }
        public string getusername()
        {
            return this.userName;

        }
        public void setuserPass(string userPassword)
        {
            this.userPassword = userPassword;

        }
        public string getuserPassword()
        {
            return this.userPassword;

        }
    }
}
