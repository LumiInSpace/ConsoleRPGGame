namespace ConsoleRPGGame.src.Main
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RarenessText { get; set; }
        public int RarenessNumber { get; set; }
        public int MaxNumber { get; set; }

        public Item(string name, string description, string rarenessText, int rarenessNumber, int maxNumber)
        {
            Name = name;
            Description = description;
            RarenessText = rarenessText;
            RarenessNumber = rarenessNumber;
            MaxNumber = maxNumber;
        }
    }
}
