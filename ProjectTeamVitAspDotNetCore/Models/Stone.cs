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
        public Stone()
        {
            Product = new HashSet<Product>();
        }
        [Key]
        public string StoneId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? StoneGm { get; set; }
        public decimal? StoneCrt { get; set; }
        public decimal? StoneRate { get; set; }
        public decimal? StoneAmt { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
