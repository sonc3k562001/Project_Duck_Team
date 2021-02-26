using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public string OdId { get; set; }
        public string PdId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public virtual Order Od { get; set; }
        public virtual Product Pd { get; set; }
    }
}
