using System;
using System.Collections.Generic;

namespace EntityDB.Models
{
    public partial class Groupe
    {
        public Groupe()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdSpecialty { get; set; }

        public virtual Specialty IdSpecialtyNavigation { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
