namespace basicEFDemo.Models
{
    using Microsoft.EntityFrameworkCore;
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options)
        :base(options)
        {
            
        }
        
        public DbSet<Order> Orders{ get; set; }
    }
}