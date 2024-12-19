namespace ConsoleRPGGame.src.Main.Chests
{
    public class Chest
    {
        public Dictionary<Rarity, float> DropRates { get; set; }

        public Rarity Rarity { get; set; }

        public Chest(Dictionary<Rarity, float> dropRates, Rarity rarity)
        {
            DropRates = dropRates;
            Rarity = rarity;
        }
    }
}
