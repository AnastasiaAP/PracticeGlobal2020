using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityDB.Models
{
    public partial class UniversityDBContext : DbContext
    {
        public UniversityDBContext()
        {
        }

        public UniversityDBContext(DbContextOptions<UniversityDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Groupe> Groupe { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7M4SSQV;Database=UniversityDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("uq_Department_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdFacultyNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.IdFaculty)
                    .HasConstraintName("fk_Id_Faculty");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("uq_Faculty_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Groupe>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("uq_Groupe_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdSpecialtyNavigation)
                    .WithMany(p => p.Groupe)
                    .HasForeignKey(d => d.IdSpecialty)
                    .HasConstraintName("fk_Id_Specialty");
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("uq_Specialty_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Specialty)
                    .HasForeignKey(d => d.IdDepartment)
                    .HasConstraintName("fk_Id_Department");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("uq_Student_Name")
                    .IsUnique();

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdGroupeNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdGroupe)
                    .HasConstraintName("fk_Id_Groupe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
