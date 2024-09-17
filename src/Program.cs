using ConsoleRPGGame.src.Main;
using System.Runtime.CompilerServices;

namespace ConsoleRPGGame.src
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            //LoadGameData.loadItems();
            Game game = new Game();
            game.Start();
            game.StartMainGame();
               
            
        }
    }
}
