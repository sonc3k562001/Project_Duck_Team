using System;
using System.Collections.Generic;

#nullable disable

namespace SecurityWithEF.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountRole = new HashSet<AccountRole>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Enable { get; set; }

        public virtual ICollection<AccountRole> AccountRole { get; set; }
    }
}
