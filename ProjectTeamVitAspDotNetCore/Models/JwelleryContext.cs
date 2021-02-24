using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class JwelleryContext : DbContext
    {
        public JwelleryContext()
        {
        }

        public JwelleryContext(DbContextOptions<JwelleryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Certify> Certify { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Dim> Dim { get; set; }
        public virtual DbSet<DimInfo> DimInfo { get; set; }
        public virtual DbSet<Metal> Metal { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<PostNew> PostNew { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stone> Stone { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
