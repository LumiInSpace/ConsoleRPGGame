namespace ConsoleRPGGame.src.Main
{
    public class Event : IChestEvent
    {
        public int Rarity { get; set; }

        public Event()
        {
            Rarity = 0;
        }

        public virtual void StartEvent(List<Item> items, Character player)
        {
            Console.WriteLine("Start Event");
        }
    }
}
