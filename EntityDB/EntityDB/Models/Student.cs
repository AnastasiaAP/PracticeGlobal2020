using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDB.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public int? IdGroupe { get; set; }

        public Groupe Groupe { get; set; }
    }
}
