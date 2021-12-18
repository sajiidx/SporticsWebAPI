using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IGamesRepository
    {
        Task<IEnumerable<Games>> Get();
        Task<Games> Get(int id);
        Task<Games> Create(Games obj);
        Task Update(Games obj);
        Task Delete(int id);
    }
}
