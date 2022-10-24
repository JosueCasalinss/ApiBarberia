using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBarberia.Core.Interface
{
    public interface IReservationRepository
    {
        Task PostReservation(Reservation reserveRequest);
        Task<Reservation> GetReserve(Reservation reserveRequest);

        int ActiveReservations();

        int ReservationInactive();


    }
}
