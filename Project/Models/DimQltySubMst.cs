using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class DimQltySubMst
    {
        public DimQltySubMst()
        {
            DimMst = new HashSet<DimMst>();
        }

        public string DimSubTypeId { get; set; }
        public string DimQlty { get; set; }

        public virtual ICollection<DimMst> DimMst { get; set; }
    }
}
