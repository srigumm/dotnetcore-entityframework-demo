using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace Api.Repository
{
    public interface IGenericRepository<T> where T: class
    {
         IQueryable<T> GetAll();
         Task<T> GetById(int id);
         Task CreateAsync(T entity);
         Task UpdateAsync(int id, T entity);
         Task DeleteAsync(int id);
         Task SaveAllAsync();
    }
}