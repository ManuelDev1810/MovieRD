using System;
using MovieProjectApi.Data;
using MovieProjectApi.Models;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Services.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MoviesForCollegeDbContext contex) : base(contex)
        {

        }
    }
}
