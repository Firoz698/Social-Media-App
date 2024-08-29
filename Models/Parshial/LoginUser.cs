using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Parshial
{
    public class LoginUser
    {
        public LoginUser()
        {
            Email = "";
            Password = "";
        }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
