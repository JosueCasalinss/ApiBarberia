using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class Reservation
    {
        public Reservation()
        {
            ReservationDetail = new HashSet<ReservationDetail>();
        }

        public int Id { get; set; }
        public int IdBarber { get; set; }
        public int IdCustomer { get; set; }
        public int IdHeadquarter { get; set; }
        public DateTime? Date { get; set; }
        public bool? State { get; set; }

        public virtual People IdBarberNavigation { get; set; }
        public virtual People IdCustomerNavigation { get; set; }
        public virtual Headquarter IdHeadquarterNavigation { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetail { get; set; }
    }
}
