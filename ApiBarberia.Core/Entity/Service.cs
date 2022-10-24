using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class Service
    {
        public Service()
        {
            InvoicedDetail = new HashSet<InvoicedDetail>();
            ReservationDetail = new HashSet<ReservationDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Preci { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<InvoicedDetail> InvoicedDetail { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetail { get; set; }
    }
}
