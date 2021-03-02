using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class Role
    {
        public string IdUser { get; set; }
        public string IdRole { get; set; }
        public bool? Eable { get; set; }

        public virtual Permission IdRoleNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
