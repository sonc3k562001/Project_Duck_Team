using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class DimInfo
    {
        public string DimInfoId { get; set; }
        public string DimType { get; set; }
        public string DimSubType { get; set; }
        public string DimCrt { get; set; }
        public decimal? DimPrice { get; set; }
        public byte[] DimImg { get; set; }
        public string Description { get; set; }
    }
}
