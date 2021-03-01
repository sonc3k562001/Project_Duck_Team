using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Role
    {
        [Key]
        public string IdRole { get; set; }
        public string StringRole { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
