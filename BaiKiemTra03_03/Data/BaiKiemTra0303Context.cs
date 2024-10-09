using System;
using System.Collections.Generic;
using BaiKiemTra03_03_x_.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra03_03_x_.Data;

public partial class BaiKiemTra0303Context : DbContext
{
    public BaiKiemTra0303Context()
    {
    }

    public BaiKiemTra0303Context(DbContextOptions<BaiKiemTra0303Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer1> Customer1s { get; set; }

    public virtual DbSet<Customer100> Customer100s { get; set; }

    public virtual DbSet<HopDong> HopDongs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Bigga-Duckky\\MSSQLSERVER3; Initial Catalog=BaiKiemTra03_03; Persist Security Info=True; User ID=sa; Password=123456; Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer1>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB85FD2D8EB2");

            entity.ToTable("Customer_1");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Customer100>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB85F368A45F");

            entity.ToTable("Customer_100");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<HopDong>(entity =>
        {
            entity.HasKey(e => e.ContracId).HasName("PK__HopDong__288171FC242DFD9E");

            entity.ToTable("HopDong");

            entity.Property(e => e.ContracId)
                .ValueGeneratedNever()
                .HasColumnName("contrac_id");
            entity.Property(e => e.ContracName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contrac_name");
            entity.Property(e => e.ContractValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("contract_value");
            entity.Property(e => e.Customer).HasColumnName("customer");
            entity.Property(e => e.SigningDate)
                .HasColumnType("datetime")
                .HasColumnName("signing_date");

            entity.HasOne(d => d.CustomerNavigation).WithMany(p => p.HopDongs)
                .HasForeignKey(d => d.Customer)
                .HasConstraintName("FK__HopDong__contrac__4F7CD00D");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__KhachHan__CD65CB85967ECFA4");

            entity.ToTable("KhachHang");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
