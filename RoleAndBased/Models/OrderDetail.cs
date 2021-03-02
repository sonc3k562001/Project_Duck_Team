using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
