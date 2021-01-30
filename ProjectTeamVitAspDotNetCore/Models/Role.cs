﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public string Id { get; set; }
        public string StringRole { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
