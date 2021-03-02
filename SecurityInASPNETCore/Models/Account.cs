using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityInASPNETCore.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }
    }
}
