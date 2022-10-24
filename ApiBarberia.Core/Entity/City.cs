using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class City
    {
        public City()
        {
            Headquarter = new HashSet<Headquarter>();
        }

        public int Id { get; set; }
        public int IdDepartament { get; set; }
        public string Name { get; set; }
        public bool? State { get; set; }

        public virtual Departament IdDepartamentNavigation { get; set; }
        public virtual ICollection<Headquarter> Headquarter { get; set; }
    }
}
