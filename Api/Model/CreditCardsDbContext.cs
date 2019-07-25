namespace Api.Model
{
   using Microsoft.EntityFrameworkCore;

    public class CreditCardsDbContext : DbContext
    {
        public CreditCardsDbContext(DbContextOptions<CreditCardsDbContext> options)
            : base(options)
        {
        }
 
        public DbSet<CreditCard> CreditCards { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}