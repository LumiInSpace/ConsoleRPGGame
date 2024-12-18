using ConsoleRPGGame.src.Main;
using System;

namespace ConsoleRPGGame.src.Utilitys
{
    public static class LootRandomizer
    {
        public static List<Item> GetLoot(Chest chest, List<Item> allItems, int maxItemCount)
        {
            Random random = new Random();
            int itemCount = random.Next(1, maxItemCount);
            List<Item> loot = new List<Item>();



            for (int i = 0; i <= itemCount; i++)
            {

                Rarity chosenRarity = GetRandomRarity(chest.DropRates);
                List<Item> filteredItems = new List<Item>();
                filteredItems.AddRange(allItems.Where(x => x.Rarity == chosenRarity));

                int randomIndex = random.Next(0, filteredItems.Count);

                loot.Add(filteredItems[randomIndex]);

            }

            return loot;
        }

        private static Rarity GetRandomRarity(Dictionary<Rarity, float> dropRates)
        {
            Random random = new Random();
            float total = dropRates.Values.Sum();
            float roll = (float)random.NextDouble() * total;

            foreach (var entry in dropRates)
            {
                if (roll < entry.Value)
                    return entry.Key;
                roll -= entry.Value;
            }

            // Fallback (sollte nie passieren)
            return Rarity.Common;
        }
    }
}

