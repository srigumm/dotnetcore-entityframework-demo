namespace Api.Repository
{
    using Api.Model;
    using System.Threading.Tasks;
    public interface ICreditCardsRepository: IGenericRepository<CreditCard>
    {
        Task<CreditCard> GetCoolestCreditCard();
    }
    
}