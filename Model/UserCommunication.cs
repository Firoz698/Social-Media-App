using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserCommunication
    {
        public UserCommunication()
        {
            Email = "";
            Password = "";
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
