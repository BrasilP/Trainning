using System.Configuration;

namespace DeckOfCardsApiTests
{
    public static class ConfigurationsHandler
    {
        public static string DeckOfCardsEndPoint = ConfigurationManager.AppSettings["ApiAddress"];
    }
}
