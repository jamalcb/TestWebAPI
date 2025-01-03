using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIWeb1.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classess> Classesses { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentLang> StudentLangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5N8J203; database=Student;trust server certificate=true; Integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classess>(entity =>
        {
            entity.HasKey(e => e.ClassId);

            entity.ToTable("classess");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("country");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("states");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("students");

            entity.Property(e => e.Gender).HasMaxLength(1);
        });

        modelBuilder.Entity<StudentLang>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.ToTable("student_langs");

            entity.Property(e => e.LangId).HasColumnName("Lang_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
