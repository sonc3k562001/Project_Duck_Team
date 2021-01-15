using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class ProdMst
    {
        public ProdMst()
        {
            ItemMst = new HashSet<ItemMst>();
        }

        public string ProdId { get; set; }
        public string ProdType { get; set; }

        public virtual ICollection<ItemMst> ItemMst { get; set; }
    }
}
