namespace ConsoleRPGGame.src.Main
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RarenessText { get; set; }
        public int RarenessNumber { get; set; }

        public Item(string name, string description, string rarenessText, int rarenessNumber)
        {

        }
    }
}
