using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FiltersInDotNetCore.Models
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-JHC23F28\\SQLEXPRESS;Database=Product;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
