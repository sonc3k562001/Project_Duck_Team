using System;
using System.Collections.Generic;

#nullable disable

namespace BuildShoppingCart.Models
{
    public partial class Permission
    {
        public Permission()
        {
            Users = new HashSet<User>();
        }

        public string Id { get; set; }
        public string PermissionName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
