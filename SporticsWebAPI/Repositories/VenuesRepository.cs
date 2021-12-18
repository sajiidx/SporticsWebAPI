using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class VenuesRepository : IVenuesRepository
    {
        private readonly SporticsContext _context;
        public VenuesRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Venues> Create(Venues person)
        {
            _context.Venues.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Venues>> Get()
        {
            return await _context.Venues.ToListAsync();
        }

        public async Task<Venues> Get(int id)
        {
            return await _context.Venues.FindAsync(id);
        }

        public async Task Update(Venues person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
