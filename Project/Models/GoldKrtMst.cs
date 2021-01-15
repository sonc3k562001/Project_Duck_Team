using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class GoldKrtMst
    {
        public GoldKrtMst()
        {
            ItemMst = new HashSet<ItemMst>();
        }

        public string GoldTypeId { get; set; }
        public string GoldCrt { get; set; }

        public virtual ICollection<ItemMst> ItemMst { get; set; }
    }
}
