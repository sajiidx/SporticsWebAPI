using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> Get();
        Task<Person> Get(string id);
        Task<Person> Create(Person obj);
        Task Update(Person obj);
        Task Delete(string id);
    }
}
