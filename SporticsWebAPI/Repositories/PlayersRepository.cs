using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class PlayersRepository : IPlayersRepository
    {
        private readonly SporticsContext _context;
        public PlayersRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Players> Create(Players person)
        {
            _context.Players.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(string id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Players>> Get()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Players> Get(string id)
        {
            return await _context.Players.FindAsync(id);
        }

        public async Task Update(Players person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
