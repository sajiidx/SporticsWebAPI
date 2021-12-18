using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class HousesRepository : IHousesRepository
    {
        private readonly SporticsContext _context;
        public HousesRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Houses> Create(Houses person)
        {
            _context.Houses.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Houses>> Get()
        {
            return await _context.Houses.ToListAsync();
        }

        public async Task<Houses> Get(int id)
        {
            return await _context.Houses.FindAsync(id);
        }

        public async Task Update(Houses person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
