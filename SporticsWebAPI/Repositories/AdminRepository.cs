using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly SporticsContext _context;
        public AdminRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Admin> Create(Admin person)
        {
            _context.Admin.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(string id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Admin>> Get()
        {
            return await _context.Admin.ToListAsync();
        }

        public async Task<Admin> Get(string id)
        {
            return await _context.Admin.FindAsync(id);
        }

        public async Task Update(Admin person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
