using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class ItemDeserializer
{
    private static readonly JsonSerializerOptions options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
        Converters =
        {
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) //um Enum-Werte als String zu lesen
        }
    };

    public static List<Item> DeserializeItems(string json)
    {
        var jsonElements = JsonSerializer.Deserialize<List<JsonElement>>(json, options);

        var items = new List<Item>();

        foreach (var element in jsonElements)
        {
            // Kategorie auslesen
            var category = element.GetProperty("Category").GetString();
            var itemCategory = Enum.Parse<ItemCategory>(category, true);

            switch (itemCategory)
            {
                case ItemCategory.Weapon:
                    items.Add(element.Deserialize<Weapon>(options));
                    break;
                //case ItemCategory.Potion:
                //    items.Add(element.Deserialize<Potion>(options));
                //    break;
                default:
                    throw new NotSupportedException($"Item-Typ '{itemCategory}' wird nicht unterstützt.");
            }

            
        }

        foreach (var item in items)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Items wurden geladen: {item.Name}");
            Console.Clear();
        }

        return items;
    }
}
