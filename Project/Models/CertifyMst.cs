using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class CertifyMst
    {
        public CertifyMst()
        {
            ItemMst = new HashSet<ItemMst>();
        }

        public string CertifyId { get; set; }
        public string CertifyType { get; set; }

        public virtual ICollection<ItemMst> ItemMst { get; set; }
    }
}
