namespace Api.Repository
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Api.Model;
    using System.Linq;
    public class GenericRepository<T>:IGenericRepository<T> where T: class,IEntity
    {
        private DbContext _context;
        public GenericRepository(DbContext dbContext)
        {
            this._context = dbContext;
        }
        public IQueryable<T> GetAll(){
            return  _context.Set<T>();
        }
        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task CreateAsync(T entity){
            await this._context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(int id, T entity){
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id){
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public Task SaveAllAsync(){
            return Task.CompletedTask;
        }
    }
}