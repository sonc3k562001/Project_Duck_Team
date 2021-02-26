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
        double Price { get; set; }
        double TotalPrice { get; set; }
    }
}
