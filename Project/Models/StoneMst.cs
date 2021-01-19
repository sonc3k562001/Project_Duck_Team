using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class StoneMst
    {
        public string StyleCode { get; set; }
        public string StoneQltyId { get; set; }
        public decimal StoneGm { get; set; }
        public decimal StonePcs { get; set; }
        public decimal StoneCrt { get; set; }
        public decimal StoneRate { get; set; }
        public decimal StoneAmt { get; set; }

        public virtual ItemMst StyleCodeNavigation { get; set; }
    }
}
