using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class DimQltyMst
    {
        public DimQltyMst()
        {
            DimMst = new HashSet<DimMst>();
        }

        public string DimQltyId { get; set; }
        public string DimQlty { get; set; }

        public virtual ICollection<DimMst> DimMst { get; set; }
    }
}
