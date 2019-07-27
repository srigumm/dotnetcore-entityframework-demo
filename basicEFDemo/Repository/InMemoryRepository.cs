namespace basicEFDemo.Repository
{
    using basicEFDemo.Models;
    using System.Collections.Generic;
    using System.Linq;
    public class InMemoryRepository : IRepository
    {
        private MyDBContext _context;
        public InMemoryRepository(MyDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetAll(){
            return _context.Orders.ToList();
        }
        public Order Get(int id){
            return _context.Orders.Where(o=>o.Id == id).FirstOrDefault();
        }
        public bool Create(Order order){
            _context.Orders.Add(order);
            _context.SaveChanges();
            return true;
        }
    }
}