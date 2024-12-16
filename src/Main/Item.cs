namespace ConsoleRPGGame.src.Main
{
    public abstract class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Rarity Rarity { get; set; }
        public int MaxValue { get; set; }

        public Item(string name, string description, Rarity rarity, int maxNumber)
        {
            Name = name;
            Description = description;
            Rarity = rarity;
            MaxValue = maxNumber;
        }
    }
}
