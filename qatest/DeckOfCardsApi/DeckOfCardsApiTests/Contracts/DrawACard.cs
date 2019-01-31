using System.Collections.Generic;

namespace DeckOfCardsApiTests.Contracts
{
    public class DrawACard
    {
        public bool success { get; set; }

        public List<card> cards { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }        
    }

    public class card
    {
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string code { get; set; }
    }
}
