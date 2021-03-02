using System;
using System.Collections.Generic;



namespace GoogleChart.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
