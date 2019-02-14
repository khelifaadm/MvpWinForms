using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWinForms.Model
{
   public class UserLogin
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Error { get; set; }

        public UserLogin(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool Login()
        {
            // access logic
            Error ="Wrong Credential";
            return false;
        }

    }
}
