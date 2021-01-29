using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public string OdId { get; set; }
        public string PdId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Order Od { get; set; }
        public virtual Product Pd { get; set; }
    }
}
