namespace graphql_demo.Repository
{
    using graphql_demo.Models;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    public interface IRepository
    {
         Task<IEnumerable<CreditCard>> Get();
         CreditCard Get(int id);
    }
}