using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly SporticsContext _context;
        public TeamsRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Teams> Create(Teams person)
        {
            _context.Teams.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teams>> Get()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Teams> Get(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public async Task Update(Teams person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
