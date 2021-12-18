using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class GamesRepository : IGamesRepository
    {
        private readonly SporticsContext _context;
        public GamesRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Games> Create(Games person)
        {
            _context.Games.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Games>> Get()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Games> Get(int id)
        {
            return await _context.Games.FindAsync(id);
        }

        public async Task Update(Games person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
