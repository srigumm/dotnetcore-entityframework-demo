namespace basicEFDemo.Repository
{
    using basicEFDemo.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    public class InMemoryRepository : IRepository
    {
        private MyDBContext _context;
        public InMemoryRepository(MyDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Order>> GetAllAsync(){
            return await _context.Orders.ToListAsync();
        }
        public async Task<Order> GetAsync(int id){
            return await _context.Orders.Where(o=>o.Id == id).FirstOrDefaultAsync();
        }
        public bool Create(Order order){
            _context.Orders.Add(order);
            _context.SaveChanges();
            return true;
        }
    }
}