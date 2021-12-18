using Microsoft.EntityFrameworkCore;
using SporticsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SporticsContext _context;
        public PersonRepository(SporticsContext context)
        {
            _context = context;
        }
        public async Task<Person> Create(Person person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task Delete(string id)
        {
            var toBeDeleted = await _context.People.FindAsync(id);
            _context.People.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> Get()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> Get(string id)
        {
            return await _context.People.FindAsync(id);
        }

        public async Task Update(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
