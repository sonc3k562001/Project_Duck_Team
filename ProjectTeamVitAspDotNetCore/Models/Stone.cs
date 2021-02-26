using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Stone
    {

        [Key]
        public string StoneId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double StoneGm { get; set; }
        public double StoneCrt { get; set; }
        public double StoneRate { get; set; }
        public double StoneAmt { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
