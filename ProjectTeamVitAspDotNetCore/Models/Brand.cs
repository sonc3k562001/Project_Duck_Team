using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string BrandId { get; set; }
        public string Brand1 { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
