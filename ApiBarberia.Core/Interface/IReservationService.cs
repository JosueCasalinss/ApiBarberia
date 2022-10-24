using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiBarberia.Core.Interface
{
    public interface IReservationService
    {
        Task<ReservationDTOresponse> PostReservation(Reservation reserveRequest);
        Task<Reservation> GetReserve(Reservation reserveRequest);
  
    }
}
