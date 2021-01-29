using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Dim
    {
        public Dim()
        {
            Products = new HashSet<Product>();
        }

        public string DimId { get; set; }
        public string Name { get; set; }
        public decimal? DimCrt { get; set; }
        public decimal? DimPcs { get; set; }
        public decimal? DimGm { get; set; }
        public decimal? DimRate { get; set; }
        public decimal? DimAmt { get; set; }
        public decimal? DimSize { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
