using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ApiBarberia.Core.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _reservationRepository;
        private readonly IRepository<People> _peopleRepository;

        public ReservationService(IReservationRepository reservationRepository, IRepository<People> peopleRepository)
        {
            _reservationRepository = reservationRepository;
            _peopleRepository = peopleRepository;
        }

        public async Task<Reservation> GetReserve(Reservation reserveRequest)
        {
            return await _reservationRepository.GetReserve(reserveRequest);
        }

        //Ejercicio1
        public async Task<ReservationDTOresponse> PostReservation(Reservation reserveRequest)
        {
            reserveRequest.State = true;
            await ValidateExisteData(reserveRequest);
            await ValidateReserve(reserveRequest);

            await _reservationRepository.PostReservation(reserveRequest);
            var reservationResponse = await GetReserve(reserveRequest);

            ReservationDTOresponse reservationDTO = new ReservationDTOresponse()
            {

                Id = reservationResponse.Id,
                IdBarber = reservationResponse.IdBarber,
                IdCustomer = reservationResponse.IdCustomer,
                IdHeadquarter = reservationResponse.IdHeadquarter,
                Date = reserveRequest.Date,
                State = reservationResponse.State
            };

            return reservationDTO;

        }


        public async Task ValidateExisteData(Reservation reserveRequest)
        {
            var Barber = await _peopleRepository.GetById(reserveRequest.IdBarber);
            var Customer = await _peopleRepository.GetById(reserveRequest.IdCustomer);

            if (Barber == null || Customer == null)
            {
                throw new Exception("A reservation data is not active");
            }
        }


        public async Task ValidateReserve(Reservation reservationResquest)
        {
            var reservation = await GetReserve(reservationResquest);

            if (reservation != null)
            {
                throw new Exception("The reservation already exists");
            }
        }


        public async Task<CustomerDTOResponse> GetCustomer()
        {
            int activas = _reservationRepository.ActiveReservations();
            int inativas = _reservationRepository.ReservationInactive()

            CustomerDTOResponse customerDTO = new CustomerDTOResponse()
            {



            };


        }


    }
}
