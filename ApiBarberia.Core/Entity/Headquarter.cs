using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class Headquarter
    {
        public Headquarter()
        {
            Invoice = new HashSet<Invoice>();
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public int IdCity { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public bool? State { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
