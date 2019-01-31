using DeckOfCardsApiTests.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsApiTests
{
    public class DeckServices
    {

        private HttpClient client;
        public DeckServices()
        {
            client = CommonFunctions.GetClient(ConfigurationsHandler.DeckOfCardsEndPoint);
        }

        public ShuffleCards GetNewDeck()
        {
            var response = client.GetAsync($"deck/new/shuffle/?deck_count=1").Result;
            var responseContent = response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ShuffleCards>(responseContent.Result);
        }

        public DrawACard DrawCards(string deck_id, int qtyCards)
        {
            var response = client.GetAsync($"deck/{deck_id}/draw/?count={qtyCards}").Result;
            var responseContent = response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DrawACard>(responseContent.Result);
        }

    }
}
