﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public bool Status { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
