using System;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaSQlITE.Models
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
