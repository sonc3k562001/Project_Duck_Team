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

        [Key]
        public string DimId { get; set; }
        public string Name { get; set; }
        public double DimCrt { get; set; }
        public double DimPcs { get; set; }
        public double DimGm { get; set; }
        public double DimRate { get; set; }
        public double DimAmt { get; set; }
        public string Certify { get; set; }
        public double DimSize { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
