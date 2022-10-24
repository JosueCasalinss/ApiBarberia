using ApiBarberia.Core.Validaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBarberia.Core.DTOs
{
    public class ReservationDTOrequest
    {
        public int IdBarber { get; set; }
        public int IdCustomer { get; set; }
        public int IdHeadquarter { get; set; }

      
       //[ValidateRangeMinuteAtribute]
        public DateTime? Date { get; set; }
        public bool? State { get; set; }

    }
}
