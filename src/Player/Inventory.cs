using ConsoleRPGGame.src.Main;

namespace ConsoleRPGGame.src.Player
{
    public class Inventory
    {
        public List<Item> PlayerInventory { get; set; } = new List<Item>();
        public int InventorySlots { get; set; } = 20;

        public bool AddItem(Item item)
        {
            if (PlayerInventory.Count < InventorySlots)
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

        public int GetFreeInventorySpace()
        {
            return InventorySlots - PlayerInventory.Count;
        }

    }
}
