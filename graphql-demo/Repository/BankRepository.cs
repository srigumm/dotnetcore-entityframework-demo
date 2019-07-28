namespace graphql_demo.Repository
{
    using graphql_demo.Util;
    using System.Net.Http.Headers;
    using System;
    using System.Net.Http;
    using graphql_demo.Models;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class BankRepository : IRepository
    {
        private IoAuthClient _oAuthClient;
        public BankRepository(IoAuthClient oAuthClient)
        {
            this._oAuthClient = oAuthClient;
        }
        public async Task<IEnumerable<CreditCard>> Get(){
            var httpClient = new HttpClient();            
            var requestMessage = new HttpRequestMessage (HttpMethod.Get, new Uri("https://api-sandbox.capitalone.com/credit-offers/products?limit=50&offset=0"));
            requestMessage.Headers.Authorization = await _oAuthClient.GetAuthenticationHeaderValueAsync ();
            httpClient.DefaultRequestHeaders.Add("Accept","application/json;v=3");
            var response = await httpClient.SendAsync (requestMessage);
            var responserecieved = await response.Content.ReadAsStringAsync();
            Console.WriteLine("RESPONSE:"+responserecieved);
            BankApiResponse bankresponse = JsonConvert.DeserializeObject<BankApiResponse>(responserecieved);

            return bankresponse.products.ToList().Select(o=> new CreditCard(){Name = o.DisplayName}).ToList();
        }
        public CreditCard Get(int id){
            return null;//source.FirstOrDefault(p=>p.Id==id);
        }
    }
}