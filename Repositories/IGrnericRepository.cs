using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    interface IGrnericRepository<T>
    {
        public Task<List<T>> Get();
        public T Get(int Id);
        public void Add(T item);
        public void Update(T entity);
        public void Delete(int Id);
        public void Save();
    }
}
