using System;
using System.Collections.Generic;

namespace EntityDB.Models
{
    public partial class Specialty
    {
        public Specialty()
        {
            Groupe = new HashSet<Groupe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdDepartment { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
    }
}
