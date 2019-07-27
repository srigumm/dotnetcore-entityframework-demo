namespace basicEFDemo.Repository
{
    using System.Collections.Generic;
    using basicEFDemo.Models;
    public interface IRepository
    {
         IEnumerable<Order> GetAll();
         Order Get(int id);
         bool Create(Order order);
    }
}