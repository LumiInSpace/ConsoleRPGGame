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

            Console.Write("Geladenes Item: ");
            var pos = Console.CursorLeft;

            foreach (var item in items)
            {
                Console.CursorLeft = pos;
                Console.Write($"{item.Name} ({item.GetType().Name})");
                Thread.Sleep(100);
                Console.CursorLeft = pos;
                Console.Write("                                                                                                 ");
            }

            Console.CursorLeft = 0;
            Console.Write("                                                                  ");
            Console.CursorLeft = 0;
            Console.WriteLine("Alle Items geladen.");

            return items;
        }
    }
}
