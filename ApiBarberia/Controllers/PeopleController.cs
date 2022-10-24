using ApiBarberia.Core.DTOs;
using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBarberia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IRepository<People> _repositoryService;

        public PeopleController(IRepository<People> repositoryService)
        {
            _repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var people = await _repositoryService.GetAll();

            return Ok(people);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var people = await _repositoryService.GetById(id);

            PeopleDtoResponse peopleDtoResponse = new PeopleDtoResponse
            {

                Id = people.Id,
                IdTypeDocument = people.IdTypeDocument,
                IdGender = people.IdGender,
                IdTypeRole = people.IdTypeRole,
                Name = people.Name,
                LastName = people.LastName,
                DocumentNumber = people.DocumentNumber,
                Telephone = people.Telephone,
                Birthday = people.Birthday,
                Email = people.Email,
                Address  = people.Address

            };
            return Ok(peopleDtoResponse);
        }

    }
}
