using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using ApiBarberia.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBarberia.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly BarbershopDBContext _context;

        public ReservationRepository(BarbershopDBContext context)
        {
            _context = context;
        }


        public async Task<Reservation> GetReserve(Reservation reserveRequest)
        {
            return await _context.Reservation.FirstOrDefaultAsync(x => x.IdBarber == reserveRequest.IdBarber &&
                                                       x.IdCustomer == reserveRequest.IdCustomer &&
                                                       x.Date == reserveRequest.Date);
        }

        public async Task PostReservation(Reservation reserveRequest)
        {

            _context.Reservation.Add(reserveRequest);
            await _context.SaveChangesAsync();

        }

        //--------Ejercicio2 ------ //

        public int ActiveReservations()
        {
            var Activas = from typeRole in _context.TypeRole
                          join people in _context.People
                            on typeRole.Id equals people.IdTypeRole
                          join reserveActive in _context.Reservation
                            on people.Id equals reserveActive.IdCustomer
                           where reserveActive.State == true
                          select reserveActive;

            return Activas.Count();
        }


        public int ReservationInactive()
        {
            var Inactivas = from typeRole in _context.TypeRole
                          join people in _context.People
                            on typeRole.Id equals people.IdTypeRole
                          join reserveActive in _context.Reservation
                            on people.Id equals reserveActive.IdCustomer
                          where reserveActive.State == false
                          select reserveActive;

            return Inactivas.Count();
        }

    }

        
}
