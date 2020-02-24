using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDB.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? IdFaculty { get; set; }

        public Faculty Faculty { get; set; }
    }
}
