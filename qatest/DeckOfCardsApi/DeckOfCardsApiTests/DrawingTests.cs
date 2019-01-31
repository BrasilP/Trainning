using DeckOfCardsApiTests.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace DeckOfCardsApiTests
{
    [TestClass]
    public class DrawingTests
    {

        [TestMethod]
        public void ExpectesDeckRemainingCardsAfterDraw()
        {
            var deckService = new DeckServices();

            var deck = deckService.GetNewDeck();

            int totalCardsDraw = 0;
            int remaining = 0;

            for (int i = 0; i < 5; i++)
            {
                var randomOneToFive = GetRandomOneToFive();
                var cardsDraw = deckService.DrawCards(deck.deck_id, randomOneToFive);

                remaining = cardsDraw.remaining;
                totalCardsDraw = totalCardsDraw + randomOneToFive;
            }

            Assert.AreEqual(deck.remaining - totalCardsDraw, remaining);
        }

        public int GetRandomOneToFive()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(1, 5);
        }


    }
}
