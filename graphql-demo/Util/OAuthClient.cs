namespace graphql_demo.Util
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System;
    public class OAuthClient : IoAuthClient
    {
        private readonly System.Uri _oauthEndpointUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly HttpClient _httpClient;

        public OAuthClient(
            System.Uri oauthEndpointUrl,
            string clientId,
            string clientSecret,
            HttpClient httpClient
        )
        {
            _oauthEndpointUrl = oauthEndpointUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _httpClient = httpClient;
        }

        private class OAuthResponse
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
        }

        public async Task<AuthenticationHeaderValue> GetAuthenticationHeaderValueAsync()
        {

            var httpResponse = await _httpClient.PostAsync(_oauthEndpointUrl, new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string> ("client_id", _clientId),
                    new KeyValuePair<string, string> ("client_secret", _clientSecret),
                    new KeyValuePair<string,string>("grant_type","client_credentials")
            })).ConfigureAwait(false);
            Console.WriteLine("StatusCode:"+httpResponse.StatusCode);
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            var oauthResponse = JsonConvert.DeserializeObject<OAuthResponse>(responseString);
            Console.WriteLine("HeaderToken::::"+oauthResponse.AccessToken);
            return new AuthenticationHeaderValue("Bearer", oauthResponse.AccessToken);
        }
        
    }
}