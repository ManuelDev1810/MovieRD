using System;
using Microsoft.EntityFrameworkCore;
using MovieProjectApi.Models;

namespace MovieProjectApi.Data
{
    public class MoviesForCollegeDbContext : DbContext
    {
        public MoviesForCollegeDbContext(DbContextOptions options) : base(options){}

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
