using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? Bdate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public string IdRole { get; set; }
        public string Enable { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
