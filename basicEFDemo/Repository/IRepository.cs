namespace basicEFDemo.Repository
{
    using System.Collections.Generic;
    using basicEFDemo.Models;
    using System.Threading.Tasks;
    public interface IRepository
    {
         Task<IEnumerable<Order>> GetAllAsync();
         Task<Order> GetAsync(int id);
         bool Create(Order order);
    }
}