namespace Api.Repository
{
    using Api.Model;
    using System.Threading.Tasks;
    public interface ICreditCardsRepository: IGenericRepository<ICreditCard>
    {
        Task<ICreditCard> GetCoolestCreditCard();
    }
    
}