using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class SporticsContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Houses> Houses { get; set; }
        public DbSet<Matches> Matches { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Venues> Venues { get; set; }
        public SporticsContext(DbContextOptions<SporticsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
