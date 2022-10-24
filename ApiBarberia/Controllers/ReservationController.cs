using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiBarberia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService  _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;

        }

        [HttpGet]

        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _reservationService.GetReservationByCustomer());
        }


        [HttpPost]
        public async Task<IActionResult> PostReservation(ReservationDTOrequest reserve)
        {
            Reservation reservation = new Reservation
            {
                IdBarber = reserve.IdBarber,
                IdCustomer = reserve.IdCustomer,       
                IdHeadquarter = reserve.IdHeadquarter,
                Date = reserve.Date
            };

            return Ok(await _reservationService.PostReservation(reservation));
        }





    }
}
