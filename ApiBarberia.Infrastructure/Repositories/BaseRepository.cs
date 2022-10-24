using ApiBarberia.Core.Entity;
using ApiBarberia.Core.Interface;
using ApiBarberia.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBarberia.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly BarbershopDBContext _context;
        private DbSet<T> _entities;

        public BaseRepository(BarbershopDBContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }


        public async Task<T> GetById(int id)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Id == id && x.State == true);
        }

        public async Task Add(T entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();

        }

        public async Task Update(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();

        }

    }
    
}
