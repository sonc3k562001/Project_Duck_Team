using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class Product
    {
        [Key]
        public string PdId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ColorId { get; set; }
        public string Size { get; set; }
        public string BrandId { get; set; }
        public string DimId { get; set; }
        public string StoneId { get; set; }
        public string IdCategory { get; set; }
        public string MetalId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual Dim Dim { get; set; }
        public virtual Category Category { get; set; }
        public virtual Metal Metal { get; set; }
        public virtual Stone Stone { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
