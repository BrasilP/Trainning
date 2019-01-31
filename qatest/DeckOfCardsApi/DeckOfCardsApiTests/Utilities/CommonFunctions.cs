using System;
using System.Configuration;
using System.Net.Http;

namespace DeckOfCardsApiTests
{
    public class CommonFunctions
    {
        public static HttpClient GetClient(string endpoint)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(endpoint)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
