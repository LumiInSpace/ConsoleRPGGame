namespace ConsoleRPGGame.src.Events
{
    public abstract class AbtractEventBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EventTyp Type { get; set; }

        protected AbtractEventBase(string name, string description, EventTyp eventTyp)
        {
            Name = name;
            Description = description;
            Type = eventTyp;
        }

        public abstract void Execute(Character player, List<Item> allItems);


    }
}
