using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string PdId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public string ColorId { get; set; }
        public double? Size { get; set; }
        public string BrandId { get; set; }
        public string DimId { get; set; }
        public string StoneId { get; set; }
        public string MetalId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual Dim Dim { get; set; }
        public virtual Metal Metal { get; set; }
        public virtual Stone Stone { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
