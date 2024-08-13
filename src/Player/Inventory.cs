using ConsoleRPGGame.src.Main;

namespace ConsoleRPGGame.src.Player
{
    public class Inventory
    {
        public List<Item> PlayerInventory { get; set; } = new List<Item>();

        public int InventorySize { get; set; }

        public Inventory()
        {

        }

        public void addItem(Item item)
        {
            if (PlayerInventory.Count >= InventorySize)
            {
                PlayerInventory.Add(item);
            }
            else
            {
                Console.WriteLine("Inventar voll. Item nicht eingesammelt!");
            }
        }

    }
}
