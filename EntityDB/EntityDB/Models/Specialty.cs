using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDB.Models
{
    public partial class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdDepartment { get; set; }

        public Department Department { get; set; }
    }
}
