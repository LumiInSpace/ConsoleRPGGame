using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRPGGame.src.Main
{
    public static class LoadGameData
    {
        public static List<Item> LoadItems()
        {
            var json = File.ReadAllText("items.json");

            var items = ItemDeserializer.DeserializeItems(json);

            Console.WriteLine("Geladenes Item: ");
            var pos = Console.CursorLeft;

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} ({item.GetType().Name})");
                Console.CursorLeft = pos;
            }

            Console.Clear();
            return items;
        }


    }
}
