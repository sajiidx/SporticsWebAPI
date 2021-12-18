using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IVenuesRepository
    {
        Task<IEnumerable<Venues>> Get();
        Task<Venues> Get(int id);
        Task<Venues> Create(Venues obj);
        Task Update(Venues obj);
        Task Delete(int id);
    }
}
