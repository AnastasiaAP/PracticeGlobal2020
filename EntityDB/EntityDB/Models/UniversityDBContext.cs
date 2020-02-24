using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Text;

namespace EntityDB.Models
{
    public partial class UniversityDBContext : DbContext
    {
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Specialty> Specialtie { get; set; }
        public virtual DbSet<Groupe> Groupe { get; set; } 
        public virtual DbSet<Student> Student { get; set; }
    }
}
