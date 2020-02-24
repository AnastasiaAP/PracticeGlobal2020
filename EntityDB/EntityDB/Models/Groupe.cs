using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDB.Models
{
    public partial class Groupe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdSpesialty { get; set; }

        public Specialty Specialty { get; set; }
    }
}
