using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IMatchesRepository
    {
        Task<IEnumerable<Matches>> Get();
        Task<Matches> Get(int id);
        Task<Matches> Create(Matches obj);
        Task Update(Matches obj);
        Task Delete(int id);
    }
}
