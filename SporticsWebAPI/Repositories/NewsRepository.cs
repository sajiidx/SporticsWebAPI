using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly SporticsContext _context;
        public NewsRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<News> Create(News person)
        {
            _context.News.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(int id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<News>> Get()
        {
            return await _context.News.ToListAsync();
        }

        public async Task<News> Get(int id)
        {
            return await _context.News.FindAsync(id);
        }

        public async Task Update(News person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
