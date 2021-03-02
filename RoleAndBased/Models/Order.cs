using System;
using System.Collections.Generic;

#nullable disable

namespace RoleAndBased.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? IdOd { get; set; }
        public string IdUser { get; set; }
        public TimeSpan? TimeCreate { get; set; }

        public virtual OrderDetail IdOdNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
