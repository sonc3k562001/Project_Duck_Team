using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class AdminLoginMst
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
