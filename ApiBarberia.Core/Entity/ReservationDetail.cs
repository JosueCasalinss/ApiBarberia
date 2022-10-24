using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class ReservationDetail
    {
        public int Id { get; set; }
        public int IdService { get; set; }
        public int IdReservation { get; set; }
        public bool? State { get; set; }

        public virtual Reservation IdReservationNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
    }
}
