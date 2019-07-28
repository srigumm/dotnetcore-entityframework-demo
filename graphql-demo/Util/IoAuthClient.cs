namespace graphql_demo.Util
{
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    public interface IoAuthClient
    {
        Task<AuthenticationHeaderValue> GetAuthenticationHeaderValueAsync();
    }
}