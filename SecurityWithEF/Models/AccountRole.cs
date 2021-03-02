using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecurityWithEF.Models
{
    public partial class AccountRole
    {
        [Key]
        public int AccountId { get; set; }
        [Key]
        public int RoleId { get; set; }
        public bool? Enable { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
