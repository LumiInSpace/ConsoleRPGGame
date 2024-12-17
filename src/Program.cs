using System.Runtime.CompilerServices;

namespace ConsoleRPGGame.src
{
    public static class Program
    {
        

        static async Task Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items = LoadGameData.LoadItems();
            Game game = new Game();
            game.Start();
            game.StartMainGame();
        }
    }
}
