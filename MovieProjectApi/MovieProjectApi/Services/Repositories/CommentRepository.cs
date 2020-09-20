using System;
using MovieProjectApi.Data;
using MovieProjectApi.Models;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Services.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(MoviesForCollegeDbContext context) : base(context)
        {
        }
    }
}
