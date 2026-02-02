using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _31_LoginFormASPCore.Models;

public partial class MicrosoftContext : DbContext
{
    public MicrosoftContext()
    {
    }

    public MicrosoftContext(DbContextOptions<MicrosoftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    public virtual DbSet<UserTbl> UserTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Microsoft;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC275D68B3BB");

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC2705061240");

            entity.ToTable("Employee_info");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<UserTbl>(entity =>
        {
            entity
                //.HasNoKey()
                .ToTable("User_tbl");

            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
