using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestDb.DataContext.Entities;

#nullable disable

namespace TestDb.DataContext
{
    public partial class DBSonTestContext : DbContext
    {
        public DBSonTestContext()
        {
        }

        public DBSonTestContext(DbContextOptions<DBSonTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=27.72.56.186,53433;Database=DBSonTest;user id=mrson2;password=a123321");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Phone, "NonClusteredIndex-20210104-232337")
                    .IsUnique();

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
