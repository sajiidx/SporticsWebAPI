using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class MatchesRepository : IMatchesRepository
    {
        private readonly SporticsContext _context;
        public MatchesRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Matches> Create(Matches person)
        {
            _context.Matches.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Matches>> Get()
        {
            return await _context.Matches.ToListAsync();
        }

        public async Task<Matches> Get(int id)
        {
            return await _context.Matches.FindAsync(id);
        }

        public async Task Update(Matches person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
