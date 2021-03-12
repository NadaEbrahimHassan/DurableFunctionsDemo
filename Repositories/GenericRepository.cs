using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public class GenericRepository<T> : IGrnericRepository<T> where T:class
    {
        private DbContext _context;
        public GenericRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item); 
        }

        public void Delete(int Id)
        {
            var entity = _context.Set<T>().Find(Id);
            _context.Set<T>().Remove(entity);
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public  async Task<T> Get(int Id)
        {
           return   _context.Set<T>().Find(Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
