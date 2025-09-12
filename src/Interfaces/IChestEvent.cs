namespace ConsoleRPGGame.src.Interfaces
{
    public interface IChestEvent
    {
        public Biome Biome { get; set; }
        public EventTyp Typ { get; set; }
        public Dictionary<Biome, >

        void StartEvent(List<Item> items, Character player);
        
    }
}
