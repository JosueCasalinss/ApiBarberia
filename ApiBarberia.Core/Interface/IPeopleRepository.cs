using ApiBarberia.Core.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBarberia.Core.Interface
{
    public interface IPeopleRepository
    {
        Task<People> GetPeople(int id);
        Task<IEnumerable<People>> GetPeoples();
    }
}