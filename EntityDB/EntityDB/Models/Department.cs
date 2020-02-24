using System;
using System.Collections.Generic;

namespace EntityDB.Models
{
    public partial class Department
    {
        public Department()
        {
            Specialty = new HashSet<Specialty>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; }
        public virtual ICollection<Specialty> Specialty { get; set; }
    }
}
