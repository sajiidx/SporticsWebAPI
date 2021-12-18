using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> Get();
        Task<Admin> Get(string id);
        Task<Admin> Create(Admin obj);
        Task Update(Admin obj);
        Task Delete(string id);
    }
}
