using System.Linq;

namespace Console
{
    class Program
    {
        static void Main(string[] args) 
        {
            var gameEngine = new CardGameEnvoirment();
            gameEngine.LoadCollectionFromJsonFile("Data/Collection/Collection.json");

            var deck1 = gameEngine.LoadDeckFromJsonFile("Data/Decks/Deck.json");
            var deck2 = gameEngine.LoadDeckFromJsonFile("Data/Decks/Deck2.json");

            var game = gameEngine.StartGame();
        }
    }
}