using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

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

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Certify> Certifies { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Dim> Dims { get; set; }
        public virtual DbSet<DimInfo> DimInfos { get; set; }
        public virtual DbSet<Metal> Metals { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Stone> Stones { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JHC23F28\\SQLEXPRESS;Database=Jwellery;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.Brand1)
                    .HasMaxLength(50)
                    .HasColumnName("Brand");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("Category");

                entity.Property(e => e.IdCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Category")
                    .IsFixedLength(true);

                entity.Property(e => e.PdId)
                    .HasMaxLength(50)
                    .HasColumnName("pd_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(250)
                    .HasColumnName("Type_Name");

                entity.HasOne(d => d.Pd)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.PdId)
                    .HasConstraintName("FK_Category_Product");
            });

            modelBuilder.Entity<Certify>(entity =>
            {
                entity.ToTable("Certify");

                entity.Property(e => e.CertifyId)
                    .HasMaxLength(50)
                    .HasColumnName("Certify_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.CertifyType)
                    .HasMaxLength(50)
                    .HasColumnName("Certify_Type");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color");

                entity.Property(e => e.ColorId)
                    .HasMaxLength(50)
                    .HasColumnName("Color_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim>(entity =>
            {
                entity.ToTable("Dim");

                entity.Property(e => e.DimId)
                    .HasMaxLength(50)
                    .HasColumnName("Dim_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.DimAmt)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Amt");

                entity.Property(e => e.DimCrt)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Crt");

                entity.Property(e => e.DimGm)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Gm");

                entity.Property(e => e.DimPcs)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Pcs");

                entity.Property(e => e.DimRate)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Rate");

                entity.Property(e => e.DimSize)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Dim_Size");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<DimInfo>(entity =>
            {
                entity.ToTable("DimInfo");

                entity.Property(e => e.DimInfoId)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

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
                entity.ToTable("Metal");

                entity.Property(e => e.MetalId)
                    .HasMaxLength(50)
                    .HasColumnName("Metal_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.MetalCrt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Metal_Crt");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Time");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("FK_Order_User1");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("Order_Detail");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.OdId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("od_id")
                    .IsFixedLength(true);

                entity.Property(e => e.PdId)
                    .HasMaxLength(50)
                    .HasColumnName("pd_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Total_Price");

                entity.HasOne(d => d.Od)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Detail_Order");

                entity.HasOne(d => d.Pd)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PdId)
                    .HasConstraintName("FK_Order_Detail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PdId);

                entity.ToTable("Product");

                entity.Property(e => e.PdId)
                    .HasMaxLength(50)
                    .HasColumnName("pd_id")
                    .IsFixedLength(true);

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_id")
                    .IsFixedLength(true);

                entity.Property(e => e.ColorId)
                    .HasMaxLength(50)
                    .HasColumnName("Color_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DimId)
                    .HasMaxLength(50)
                    .HasColumnName("Dim_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Image1).HasColumnType("image");

                entity.Property(e => e.Image2).HasColumnType("image");

                entity.Property(e => e.MetalId)
                    .HasMaxLength(50)
                    .HasColumnName("Metal_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoneId)
                    .HasMaxLength(50)
                    .HasColumnName("Stone_id")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Product_Color");

                entity.HasOne(d => d.Dim)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DimId)
                    .HasConstraintName("FK_Product_Dim");

                entity.HasOne(d => d.Metal)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MetalId)
                    .HasConstraintName("FK_Product_Metal");

                entity.HasOne(d => d.Stone)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoneId)
                    .HasConstraintName("FK_Product_Stone");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StringRole)
                    .HasMaxLength(50)
                    .HasColumnName("String_Role");
            });

            modelBuilder.Entity<Stone>(entity =>
            {
                entity.ToTable("Stone");

                entity.Property(e => e.StoneId)
                    .HasMaxLength(50)
                    .HasColumnName("Stone_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoneAmt)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Stone_Amt");

                entity.Property(e => e.StoneCrt)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Stone_Crt");

                entity.Property(e => e.StoneGm)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Stone_Gm");

                entity.Property(e => e.StoneRate)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("Stone_Rate");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("User");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Avatar).HasMaxLength(250);

                entity.Property(e => e.Bdate).HasColumnType("date");

                entity.Property(e => e.ConfirmPassword).HasColumnName("Confirm_Password");

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IdRole)
                    .HasMaxLength(10)
                    .HasColumnName("Id_Role")
                    .HasDefaultValueSql("((4))")
                    .IsFixedLength(true);

                entity.Property(e => e.Lname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
