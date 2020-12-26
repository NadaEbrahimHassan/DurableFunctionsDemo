using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGrnericRepository<T>
    {
         Task<List<T>> Get();
         T Get(int Id);
         void Add(T item);
         void Update(T entity);
         void Delete(int Id);
         void Save();
    }
}
