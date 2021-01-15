using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class BrandMst
    {
        public BrandMst()
        {
            ItemMst = new HashSet<ItemMst>();
        }

        public string BrandId { get; set; }
        public string BrandType { get; set; }

        public virtual ICollection<ItemMst> ItemMst { get; set; }
    }
}
