﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SecurityWithASP.NETAndEF.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountRoles = new HashSet<AccountRole>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Enable { get; set; }

        public virtual ICollection<AccountRole> AccountRoles { get; set; }
    }
}
