using System;
using System.Collections.Generic;

namespace EntityDB.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Department = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Department> Department { get; set; }
    }
}
