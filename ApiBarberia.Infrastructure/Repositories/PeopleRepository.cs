using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using ApiBarberia.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBarberia.Infrastructure.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {

        private readonly BarbershopDBContext _context;

        public PeopleRepository(BarbershopDBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<People>> GetPeoples()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<People> GetPeople(int id)
        {
            return await _context.People.FirstOrDefaultAsync(x => x.Id == id && x.State == true);
        }




    }
}
