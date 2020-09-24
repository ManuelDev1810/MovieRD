using System;
using System.Collections.Generic;
using MovieProjectApi.Models;

namespace MovieProjectApi.Services.Interfaces
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        IEnumerable<Comment> GetAllWithMovie();
        IEnumerable<Comment> GetAllByMovieID(string movieID);
    }
}
