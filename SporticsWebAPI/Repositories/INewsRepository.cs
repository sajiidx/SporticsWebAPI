using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> Get();
        Task<News> Get(int id);
        Task<News> Create(News obj);
        Task Update(News obj);
        Task Delete(int id);
    }
}
