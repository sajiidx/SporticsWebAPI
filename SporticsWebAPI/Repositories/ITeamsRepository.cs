using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface ITeamsRepository
    {
        Task<IEnumerable<Teams>> Get();
        Task<Teams> Get(int id);
        Task<Teams> Create(Teams obj);
        Task Update(Teams obj);
        Task Delete(int id);
    }
}
