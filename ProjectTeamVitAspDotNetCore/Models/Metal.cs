using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Metal
    {


        [Key]
        public string MetalId { get; set; }
        public string Name { get; set; }
        public string MetalCrt { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
