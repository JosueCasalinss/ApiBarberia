using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBarberia.Core.DTOs
{
    public class ReservationDTOresponse
    {
        public int Id { get; set; }
        public int IdBarber { get; set; }
        public int IdCustomer { get; set; }
        public int IdHeadquarter { get; set; }
        public DateTime? Date { get; set; }
        public bool? State { get; set; }


    }
}
