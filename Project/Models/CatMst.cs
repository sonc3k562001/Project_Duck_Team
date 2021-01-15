using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class CatMst
    {
        public CatMst()
        {
            ItemMst = new HashSet<ItemMst>();
        }

        public string CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<ItemMst> ItemMst { get; set; }
    }
}
