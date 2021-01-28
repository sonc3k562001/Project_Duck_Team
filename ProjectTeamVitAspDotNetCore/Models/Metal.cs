using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Metal
    {
        public Metal()
        {
            Products = new HashSet<Product>();
        }

        public string MetalId { get; set; }
        public string Name { get; set; }
        public string MetalCrt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
