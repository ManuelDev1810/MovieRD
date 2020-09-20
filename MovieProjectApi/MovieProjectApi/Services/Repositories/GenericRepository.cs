using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieProjectApi.Data;
using MovieProjectApi.Services.Interfaces;

namespace MovieProjectApi.Services.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MoviesForCollegeDbContext _context;

        public GenericRepository(MoviesForCollegeDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public IEnumerable<T> GetAll()
        {
             return _context.Set<T>().ToList();
        }

        public async Task<T> GetByiD(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
             _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
