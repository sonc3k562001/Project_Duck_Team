using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string IdRole { get; set; }
        public string Address { get; set; }

        public virtual Permission IdRoleNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
