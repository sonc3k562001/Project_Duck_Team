using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Areas.Identity.Data
{
    public class ApplicationUser:IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Birthday { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Phone { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
    }
}
