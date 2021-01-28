using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Stone
    {
        public Stone()
        {
            Products = new HashSet<Product>();
        }

        public string StoneId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? StoneGm { get; set; }
        public decimal? StoneCrt { get; set; }
        public decimal? StoneRate { get; set; }
        public decimal? StoneAmt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
