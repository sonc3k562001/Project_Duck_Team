using System;
using System.Collections.Generic;


namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Bdate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ZipCode { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public bool? Eable { get; set; }
        public string IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
