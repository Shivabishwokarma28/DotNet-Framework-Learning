using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _34_WebAPI_CRUD.Models;

public partial class SchoolManagementContext : DbContext
{
    public SchoolManagementContext()
    {
    }

    public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database= School Management; Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__B0970557C3016941");

            entity.ToTable("Class", tb => tb.HasTrigger("TriClass"));

            entity.Property(e => e.ClassId).HasColumnName("Class_ID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Class_Name");
            entity.Property(e => e.Section)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TId).HasColumnName("T_ID");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Course__3214EC07155E8F25");

            entity.ToTable("Course");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CId).HasColumnName("C_ID");
            entity.Property(e => e.CName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("C_Name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC0756603395");

            entity.ToTable("Student");

            entity.Property(e => e.StName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("St_Name");
            entity.Property(e => e.StPhone).HasColumnName("St_Phone");
            entity.Property(e => e.StRoll).HasColumnName("St_Roll");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("PK__Teacher__83BB1FB2DBDD1717");

            entity.ToTable("Teacher");

            entity.Property(e => e.TId).HasColumnName("T_ID");
            entity.Property(e => e.TAddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("T_Address");
            entity.Property(e => e.TName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("T_Name");
            entity.Property(e => e.TPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("T_Phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
