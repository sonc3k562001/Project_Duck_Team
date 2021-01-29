using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Category
    {
        public string IdCategory { get; set; }
        public string TypeName { get; set; }
        public string PdId { get; set; }

        public virtual Product Pd { get; set; }
    }
}
