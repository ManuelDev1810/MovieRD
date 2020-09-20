using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieProjectApi.Services.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByID(string id);
        IEnumerable<T> GetAll();
        Task Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
