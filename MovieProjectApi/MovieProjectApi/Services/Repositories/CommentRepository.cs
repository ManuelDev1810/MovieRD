using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieProjectApi.Data;
using MovieProjectApi.Models;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Services.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private MoviesForCollegeDbContext context { get; set; }
        public CommentRepository(MoviesForCollegeDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Comment> GetAllWithMovie()
        {
            var data = context.Comment.Include(m => m.Movie).ToList();
            return data;
        }

        public IEnumerable<Comment> GetAllByMovieID(string movieID)
        {
            var data = context.Comment.Where(m => m.MovieId == new Guid(movieID)).Include(m => m.Movie).ToList();
            return data;
        }
    }
}
