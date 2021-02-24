using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Models
{
    public class ProductOrder
    {
        public Product Product { get; set; }
        int Quantity { get; set; }
        decimal? Price { get; set; }
        decimal? TotalPrice { get; set; }
    }
}
