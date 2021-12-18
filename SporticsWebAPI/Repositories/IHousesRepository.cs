using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IHousesRepository
    {
        Task<IEnumerable<Houses>> Get();
        Task<Houses> Get(int id);
        Task<Houses> Create(Houses obj);
        Task Update(Houses obj);
        Task Delete(int id);
    }
}
