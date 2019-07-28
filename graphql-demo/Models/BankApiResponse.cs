namespace graphql_demo.Models
{
    using Newtonsoft.Json;
    public class BankApiResponse
    {
        public int productCount {get;set;}
        public Product[] products {get;set;}
    }
    public class Product{
        [JsonProperty("productId")]
        public string ProductId {get;set;}
        [JsonProperty("productDisplayName")]
        public string DisplayName {get;set;}
        [JsonProperty("applyNowLink")]
        public string ApplyNowLink{get;set;}
    }
}