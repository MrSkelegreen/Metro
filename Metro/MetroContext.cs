using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Metro
{
    public partial class MetroContext : DbContext
    {
        public MetroContext()
        {
        }

        public MetroContext(DbContextOptions<MetroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<Letter> Letters { get; set; } = null!;
        public virtual DbSet<LetterType> LetterTypes { get; set; } = null!;
        public virtual DbSet<Pay> Pays { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Metro;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.Idcoupon);

                entity.ToTable("Coupon");

                entity.Property(e => e.Idcoupon).HasColumnName("IDCoupon");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.EndDate).HasColumnType("date");
            });

            modelBuilder.Entity<Letter>(entity =>
            {
                entity.HasKey(e => e.Idletter);

                entity.Property(e => e.Idletter).HasColumnName("IDLetter");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Letters)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Letters_Users");

                entity.HasOne(d => d.LetterTypeNavigation)
                    .WithMany(p => p.Letters)
                    .HasForeignKey(d => d.LetterType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Letters_LetterTypes");
            });

            modelBuilder.Entity<LetterType>(entity =>
            {
                entity.HasKey(e => e.IdletterType);

                entity.Property(e => e.IdletterType).HasColumnName("IDLetterType");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => e.Idpay)
                    .HasName("PK_AutoPay");

                entity.ToTable("Pay");

                entity.Property(e => e.Idpay).HasColumnName("IDPay");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Idcoupon).HasColumnName("IDCoupon");

                entity.Property(e => e.Sum).HasColumnType("money");

                entity.HasOne(d => d.IdcouponNavigation)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.Idcoupon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_Coupon");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Idticket);

                entity.Property(e => e.Idticket).HasColumnName("IDTicket");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tickets_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firtsname).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.HasOne(d => d.IdCouponNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdCoupon)
                    .HasConstraintName("FK_Users_Coupon");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
