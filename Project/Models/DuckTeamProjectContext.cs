using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Models
{
    public partial class DuckTeamProjectContext : DbContext
    {
        public DuckTeamProjectContext()
        {
        }

        public DuckTeamProjectContext(DbContextOptions<DuckTeamProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLoginMst> AdminLoginMst { get; set; }
        public virtual DbSet<BrandMst> BrandMst { get; set; }
        public virtual DbSet<CartList> CartList { get; set; }
        public virtual DbSet<CatMst> CatMst { get; set; }
        public virtual DbSet<CertifyMst> CertifyMst { get; set; }
        public virtual DbSet<DimInfoMst> DimInfoMst { get; set; }
        public virtual DbSet<DimMst> DimMst { get; set; }
        public virtual DbSet<DimQltyMst> DimQltyMst { get; set; }
        public virtual DbSet<DimQltySubMst> DimQltySubMst { get; set; }
        public virtual DbSet<GoldKrtMst> GoldKrtMst { get; set; }
        public virtual DbSet<Inquiry> Inquiry { get; set; }
        public virtual DbSet<ItemMst> ItemMst { get; set; }
        public virtual DbSet<JewelTypeMst> JewelTypeMst { get; set; }
        public virtual DbSet<ProdMst> ProdMst { get; set; }
        public virtual DbSet<StoneMst> StoneMst { get; set; }
        public virtual DbSet<StoneQltyMst> StoneQltyMst { get; set; }
        public virtual DbSet<UserRegMst> UserRegMst { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JHC23F28\\SQLEXPRESS;Database=DuckTeamProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLoginMst>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrandMst>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BrandType)
                    .IsRequired()
                    .HasColumnName("Brand_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CartList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("Product_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatMst>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId)
                    .HasColumnName("Cat_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("Cat_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertifyMst>(entity =>
            {
                entity.HasKey(e => e.CertifyId);

                entity.Property(e => e.CertifyId)
                    .HasColumnName("Certify_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CertifyType)
                    .IsRequired()
                    .HasColumnName("Certify_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimInfoMst>(entity =>
            {
                entity.HasKey(e => e.DimId);

                entity.Property(e => e.DimId)
                    .HasColumnName("DimID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DimCrt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimImg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimPrice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DimSubType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimMst>(entity =>
            {
                entity.HasKey(e => e.StyleCode);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("Style_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.DimQltyId)
                    .HasColumnName("DimQlty_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DimRate)
                    .HasColumnName("Dim_Rate")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimSize)
                    .HasColumnName("Dim_Size")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DimSubTypeId)
                    .HasColumnName("DimSubType_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.DimQlty)
                    .WithMany(p => p.DimMst)
                    .HasForeignKey(d => d.DimQltyId)
                    .HasConstraintName("FK_DimMst_DimQltyMst");

                entity.HasOne(d => d.DimSubType)
                    .WithMany(p => p.DimMst)
                    .HasForeignKey(d => d.DimSubTypeId)
                    .HasConstraintName("FK_DimMst_DimQltySubMst");

                entity.HasOne(d => d.StyleCodeNavigation)
                    .WithOne(p => p.DimMst)
                    .HasForeignKey<DimMst>(d => d.StyleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimMst_ItemMst");
            });

            modelBuilder.Entity<DimQltyMst>(entity =>
            {
                entity.HasKey(e => e.DimQltyId);

                entity.Property(e => e.DimQltyId)
                    .HasColumnName("DimQlty_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DimQlty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimQltySubMst>(entity =>
            {
                entity.HasKey(e => e.DimSubTypeId);

                entity.Property(e => e.DimSubTypeId)
                    .HasColumnName("DimSubType_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DimQlty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoldKrtMst>(entity =>
            {
                entity.HasKey(e => e.GoldTypeId);

                entity.Property(e => e.GoldTypeId)
                    .HasColumnName("GoldType_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GoldCrt)
                    .IsRequired()
                    .HasColumnName("Gold_Crt")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inquiry>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cdate).HasColumnType("date");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemMst>(entity =>
            {
                entity.HasKey(e => e.StyleCode);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("Style_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CatId)
                    .HasColumnName("Cat_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CertifyId)
                    .HasColumnName("Certify_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GoldAmt)
                    .HasColumnName("Gold_Amt")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.GoldMaking)
                    .HasColumnName("Gold_Making")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.GoldRate)
                    .HasColumnName("Gold_Rate")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.GoldTypeId)
                    .HasColumnName("GoldType_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GoldWt)
                    .HasColumnName("Gold_Wt")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.NetGold)
                    .HasColumnName("Net_Gold")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.OtherMaking)
                    .HasColumnName("Other_Making")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.Pairs).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ProdId)
                    .HasColumnName("Prod_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProdQuality)
                    .IsRequired()
                    .HasColumnName("Prod_Quality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StoneMaking)
                    .HasColumnName("Stone_Making")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.StoneWt)
                    .HasColumnName("Stone_Wt")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.TotGrossWt)
                    .HasColumnName("Tot_Gross_Wt")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.TotMaking)
                    .HasColumnName("Tot_Making")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.Wstg).HasColumnType("numeric(10, 3)");

                entity.Property(e => e.WstgPer)
                    .HasColumnName("Wstg_Per")
                    .HasColumnType("numeric(10, 3)");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ItemMst)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ItemMst_BrandMst");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.ItemMst)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_ItemMst_CatMst");

                entity.HasOne(d => d.Certify)
                    .WithMany(p => p.ItemMst)
                    .HasForeignKey(d => d.CertifyId)
                    .HasConstraintName("FK_ItemMst_CertifyMst");

                entity.HasOne(d => d.GoldType)
                    .WithMany(p => p.ItemMst)
                    .HasForeignKey(d => d.GoldTypeId)
                    .HasConstraintName("FK_ItemMst_GoldKrtMst");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ItemMst)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_ItemMst_ProdMst");
            });

            modelBuilder.Entity<JewelTypeMst>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.JewelleryType)
                    .IsRequired()
                    .HasColumnName("Jewellery_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdMst>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.Property(e => e.ProdId)
                    .HasColumnName("Prod_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProdType)
                    .IsRequired()
                    .HasColumnName("Prod_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoneMst>(entity =>
            {
                entity.HasKey(e => e.StyleCode);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("Style_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoneAmt)
                    .HasColumnName("Stone_Amt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneCrt)
                    .HasColumnName("Stone_Crt")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneGm)
                    .HasColumnName("Stone_Gm")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StonePcs)
                    .HasColumnName("Stone_Pcs")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StoneQltyId)
                    .IsRequired()
                    .HasColumnName("StoneQlty_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoneRate)
                    .HasColumnName("Stone_Rate")
                    .HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.StyleCodeNavigation)
                    .WithOne(p => p.StoneMst)
                    .HasForeignKey<StoneMst>(d => d.StyleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoneMst_StoneQltyMst");
            });

            modelBuilder.Entity<StoneQltyMst>(entity =>
            {
                entity.HasKey(e => e.StoneQltyId);

                entity.Property(e => e.StoneQltyId)
                    .HasColumnName("StoneQlty_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoneQlty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRegMst>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .IsRequired()
                    .HasColumnName("cdate")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasColumnName("dob")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("emailID")
                    .HasColumnType("text");

                entity.Property(e => e.MobNo)
                    .IsRequired()
                    .HasColumnName("mobNo")
                    .HasColumnType("text");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFname)
                    .IsRequired()
                    .HasColumnName("userFname")
                    .HasColumnType("text");

                entity.Property(e => e.UserLname)
                    .IsRequired()
                    .HasColumnName("userLname")
                    .HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
