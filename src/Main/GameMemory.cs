using System.Dynamic;

namespace ConsoleRPGGame.src.Main
{
    public class GameMemory
    {
        public Character Player { get; set; }
        public Biome CurrentBiome { get; set; }
        

        public GameMemory(Character player, Biome currentBiome)
        {
            Player = player;
            CurrentBiome = currentBiome;
        }

        public void UpdateBiome(Biome newBiome)
        {
            CurrentBiome = newBiome;
        }

        public void UpdatePlayer(Character updatedPlayer)
        {
            Player = updatedPlayer;
        }

        public Biome GetCurrentBiome()
        {
            return CurrentBiome;
        }

        public Character GetPlayer()
        {
            return Player;
        }
    }
}
