using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BuildShoppingCart.Models
{
    public partial class mydbContext : DbContext
    {
        public mydbContext()
        {
        }

        public mydbContext(DbContextOptions<mydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JHC23F28\\SQLEXPRESS;Database=mydb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdOd).HasColumnName("Id_OD");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(10)
                    .HasColumnName("Id_User")
                    .IsFixedLength(true);

                entity.Property(e => e.TimeCreate)
                    .HasColumnName("Time_Create")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdOdNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdOd)
                    .HasConstraintName("FK_Order_OrderDetail");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK_OrderDetail_Product1");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PermissionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.IdRole)
                    .HasMaxLength(10)
                    .HasColumnName("Id_Role")
                    .HasDefaultValueSql("((4))")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_User_Permission");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
