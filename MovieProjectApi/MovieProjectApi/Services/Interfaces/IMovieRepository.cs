using System;
using System.Collections.Generic;
using MovieProjectApi.Models;

namespace MovieProjectApi.Services.Interfaces
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        IEnumerable<Movie> GetAllWithComments();
    }
}
