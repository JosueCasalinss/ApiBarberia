using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Core.Entity
{
    public partial class People : BaseEntity
    {
        public People()
        {
            InvoiceIdBarberNavigation = new HashSet<Invoice>();
            InvoiceIdCostumerNavigation = new HashSet<Invoice>();
            ReservationIdBarberNavigation = new HashSet<Reservation>();
            ReservationIdCustomerNavigation = new HashSet<Reservation>();
        }

        public int IdTypeDocument { get; set; }
        public int IdGender { get; set; }
        public int IdTypeRole { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public string Telephone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual TypeDocument IdTypeDocumentNavigation { get; set; }
        public virtual TypeRole IdTypeRoleNavigation { get; set; }
        public virtual ICollection<Invoice> InvoiceIdBarberNavigation { get; set; }
        public virtual ICollection<Invoice> InvoiceIdCostumerNavigation { get; set; }
        public virtual ICollection<Reservation> ReservationIdBarberNavigation { get; set; }
        public virtual ICollection<Reservation> ReservationIdCustomerNavigation { get; set; }
    }
}
