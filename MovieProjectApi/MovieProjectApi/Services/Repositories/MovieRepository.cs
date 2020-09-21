using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieProjectApi.Data;
using MovieProjectApi.Models;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Services.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MoviesForCollegeDbContext context { get; set; }
        public MovieRepository(MoviesForCollegeDbContext contex) : base(contex)
        {
            this.context = contex;
        }

        public IEnumerable<Movie> GetAllWithComments()
        {
            return context.Movie.Include(a => a.Comments).ToList();
        }
    }
}
