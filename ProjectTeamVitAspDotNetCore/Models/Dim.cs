using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Dim
    {
        public Dim()
        {
            Product = new HashSet<Product>();
        }
        [Key]
        public string DimId { get; set; }
        public string Name { get; set; }
        public decimal? DimCrt { get; set; }
        public decimal? DimPcs { get; set; }
        public decimal? DimGm { get; set; }
        public decimal? DimRate { get; set; }
        public decimal? DimAmt { get; set; }
        public string Certify { get; set; }
        public decimal? DimSize { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
