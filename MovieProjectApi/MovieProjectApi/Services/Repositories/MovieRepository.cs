using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<Movie> GetByIDWithComments(string id)
        {
            return await context.Movie.Where(m => m.ID == new Guid(id)).Include(a => a.Comments).FirstOrDefaultAsync();
        }
    }
}
