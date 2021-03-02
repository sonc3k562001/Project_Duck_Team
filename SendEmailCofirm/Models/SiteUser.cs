using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SendEmailCofirm.Models
{
    public class SiteUser
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsValid { get; set; }
    }
}
