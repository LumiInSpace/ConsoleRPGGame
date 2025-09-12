using ConsoleRPGGame.src.Main;

namespace ConsoleRPGGame.src.Player
{
    public class Inventory
    {
        public List<Item> PlayerInventory { get; set; } = new List<Item>();
        public int MaxSlots { get; set; } = 20;
        public int UsedSlots => PlayerInventory.Count;
        public int FreeSlots => MaxSlots - UsedSlots;


        public bool AddItem(Item item)
        {
            if (PlayerInventory.Count < MaxSlots)
            {
                PlayerInventory.Add(item);
                Console.WriteLine($"{item.Name} eingesammelt.");
                return true;
            }
            else
            {
                Console.WriteLine("Inventar voll. Item nicht eingesammelt!");
                return false;
            }
        }

        public bool RemoveItem(Item item)
        {
            if (PlayerInventory.Contains(item))
            {
                PlayerInventory.Remove(item);
                Console.WriteLine($"{item.Name} weggelegt.");
                return true;
            }

            Console.WriteLine("Item nicht im Inventar.");
            return false;
        }

        public void DisplayItems()
        {
            Console.WriteLine("Inventory:\n");
            foreach (Item item in PlayerInventory)
            {
                Console.ForegroundColor = Gui.GetRarityColor(item.Rarity);
                Console.WriteLine($"{item.Name} [{item.Rarity}] [{item.Category}]");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
