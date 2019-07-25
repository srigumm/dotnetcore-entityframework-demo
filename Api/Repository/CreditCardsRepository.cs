namespace Api.Repository
{
    using Api.Model;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    public class CreditCardsRepository : GenericRepository<CreditCard>, ICreditCardsRepository
    {
        public CreditCardsRepository(CreditCardsDbContext dbContext)
        : base(dbContext)
        {
            
        }        
        public async Task<CreditCard> GetCoolestCreditCard()
        {
            return await GetAll()
                .OrderByDescending(c => c.Name)
                .FirstOrDefaultAsync();
        }
    }
    
}