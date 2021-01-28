using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Email { get; set; }

        public virtual User EmailNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
