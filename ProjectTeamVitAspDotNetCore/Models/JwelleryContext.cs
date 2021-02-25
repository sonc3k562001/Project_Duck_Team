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
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stone> Stone { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Jwellery;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_Id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.BrandName)
                    .HasColumnName("Brand_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.Property(e => e.IdCategory)
                    .HasColumnName("Id_Category")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TypeName)
                    .HasColumnName("Type_Name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Certify>(entity =>
            {
                entity.Property(e => e.CertifyId)
                    .HasColumnName("Certify_ID")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CertifyType)
                    .HasColumnName("Certify_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.ColorId)
                    .HasColumnName("Color_Id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim>(entity =>
            {
                entity.Property(e => e.DimId)
                    .HasColumnName("Dim_Id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Certify).HasMaxLength(250);

                entity.Property(e => e.DimAmt)
                    .HasColumnName("Dim_Amt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimCrt)
                    .HasColumnName("Dim_Crt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimGm)
                    .HasColumnName("Dim_Gm")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimPcs)
                    .HasColumnName("Dim_Pcs")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimRate)
                    .HasColumnName("Dim_Rate")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimSize)
                    .HasColumnName("Dim_Size")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<DimInfo>(entity =>
            {
                entity.Property(e => e.DimInfoId)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DimCrt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimImg).HasColumnType("image");

                entity.Property(e => e.DimPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DimSubType).HasMaxLength(50);

                entity.Property(e => e.DimType).HasMaxLength(50);
            });

            modelBuilder.Entity<Metal>(entity =>
            {
                entity.Property(e => e.MetalId)
                    .HasColumnName("Metal_Id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MetalCrt)
                    .HasColumnName("Metal_Crt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Birthday)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("Order_Detail");

                entity.Property(e => e.OdId)
                    .IsRequired()
                    .HasColumnName("od_id")
                    .HasMaxLength(50);

                entity.Property(e => e.PdId)
                    .IsRequired()
                    .HasColumnName("pd_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Od)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Order");

                entity.HasOne(d => d.Pd)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.PdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PdId);

                entity.Property(e => e.PdId)
                    .HasColumnName("pd_id")
                    .HasMaxLength(50);

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ColorId)
                    .HasColumnName("Color_id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DimId)
                    .HasColumnName("Dim_id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.IdCategory)
                    .HasColumnName("Id_Category")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MetalId)
                    .HasColumnName("Metal_id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.StoneId)
                    .HasColumnName("Stone_id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Product_Color");

                entity.HasOne(d => d.Dim)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.DimId)
                    .HasConstraintName("FK_Product_Dim");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.Metal)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.MetalId)
                    .HasConstraintName("FK_Product_Metal");

                entity.HasOne(d => d.Stone)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.StoneId)
                    .HasConstraintName("FK_Product_Stone");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StringRole)
                    .HasColumnName("String_Role")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Stone>(entity =>
            {
                entity.Property(e => e.StoneId)
                    .HasColumnName("Stone_Id")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoneAmt)
                    .HasColumnName("Stone_Amt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneCrt)
                    .HasColumnName("Stone_Crt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneGm)
                    .HasColumnName("Stone_Gm")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneRate)
                    .HasColumnName("Stone_Rate")
                    .HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Avatar).HasMaxLength(250);

                entity.Property(e => e.Bdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword).HasColumnName("Confirm_Password");

                entity.Property(e => e.Eable).HasDefaultValueSql("((1))");

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IdRole)
                    .HasColumnName("Id_Role")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.Lname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("Zip_Code")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}

