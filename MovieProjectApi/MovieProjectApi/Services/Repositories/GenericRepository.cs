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
            try
            {
                await _context.Set<T>().AddAsync(entity);
                _context.SaveChanges();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<T> GetAll()
        {
             return _context.Set<T>().ToList();
        }

        public async Task<T> GetByID(string id)
        {
            return await _context.Set<T>().FindAsync(new Guid(id));
        }

        public void Remove(T entity)
        {
             _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
