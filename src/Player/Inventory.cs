using ConsoleRPGGame.src.Main;

namespace ConsoleRPGGame.src.Player
{
    public class Inventory
    {
        public List<Item> PlayerInventory { get; set; } = new List<Item>();

        public int InventorySlots { get; set; }

        public Inventory()
        {

        }

        public void AddItem(Item item)
        {
            if (PlayerInventory.Count >= InventorySlots)
            {
                PlayerInventory.Add(item);
                Console.WriteLine($"{item.Name} eingesammelt.");
            }
            else
            {
                Console.WriteLine("Inventar voll. Item nicht eingesammelt!");
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
                Console.WriteLine($"{item.Name} [{item.Rarity}] [{item.Category}]");
            }
        }

    }
}
