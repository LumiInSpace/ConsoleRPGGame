namespace ConsoleRPGGame.src.Main
{
    public class Event : IEvent
    {
        public int Rarity { get; set; }

        public Event()
        {
            Rarity = 0;
        }

        public virtual void StartEvent()
        {
            Console.WriteLine("Start Event");
        }
    }
}
