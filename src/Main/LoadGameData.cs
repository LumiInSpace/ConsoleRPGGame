using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleRPGGame.src.Main
{
    public static class LoadGameData
    {
        public static List<Item> LoadItems()
        {
            var json = File.ReadAllText("C:\\Dev\\ConsoleRPGGame\\items.json");

            var items = ItemDeserializer.DeserializeItems(json);

            foreach (var item in items)
            {
                Console.WriteLine($"Geladenes Item: {item.Name} ({item.GetType().Name})");
                Console.Clear();
            }

            return items;
        }


    }
}
