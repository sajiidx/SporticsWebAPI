using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IPlayersRepository
    {
        Task<IEnumerable<Players>> Get();
        Task<Players> Get(string id);
        Task<Players> Create(Players obj);
        Task Update(Players obj);
        Task Delete(string id);
    }
}
