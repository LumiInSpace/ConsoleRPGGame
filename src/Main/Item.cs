namespace ConsoleRPGGame.src.Main
{
    public abstract class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RarenessText { get; set; }
        public int RarenessNumber { get; set; }
        public int MaxValue { get; set; }

        public Item(string name, string description, string rarenessText, int rarenessNumber, int maxNumber)
        {
            Name = name;
            Description = description;
            RarenessText = rarenessText;
            RarenessNumber = rarenessNumber;
            MaxValue = maxNumber;
        }
    }
}
