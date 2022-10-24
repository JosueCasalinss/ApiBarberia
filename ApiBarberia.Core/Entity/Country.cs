using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class Country
    {
        public Country()
        {
            Departament = new HashSet<Departament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<Departament> Departament { get; set; }
    }
}
