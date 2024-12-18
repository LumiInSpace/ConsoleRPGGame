using System.Diagnostics;

namespace ConsoleRPGGame.src.Utilitys.Gui
{
    public static class Gui
    {
        public static void ShowInfoBar()
        {
            Console.WriteLine(@" ________________________________________________________");
            Console.WriteLine(@"|  Health: 100/100    Coins: 100     Inventar: 5/63      |");
            Console.WriteLine(@" \______________________________________________________/");
        }

        public static void ShowTakeLootScreen(List<Item> loot, Character player)
        {
            while (loot.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Du hast folgende Items erhalten:\n");

                
                for (int i = 0; i < loot.Count; i++)
                {
                    Console.ForegroundColor = GetRarityColor(loot[i].Rarity);
                    Console.WriteLine($"[{i + 1}] {loot[i].Name} [{loot[i].Rarity}]");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine($"[{loot.Count + 1}] Alles nehmen");
                Console.WriteLine($"[{loot.Count + 2}] Exit\n");

                int selectedValue = 0;

                
                while (true)
                {
                    Console.Write("[#]: ");
                    string selection = Console.ReadLine();
                    CheckedInput checkedInput = CheckUserInput(selection, 1, loot.Count + 2);
                    selectedValue = checkedInput.Value;

                    if (checkedInput.IsValid) { break; }
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                }

                if (selectedValue <= loot.Count)
                {
                    var selectedItem = loot[selectedValue - 1];
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Beschreibung: {selectedItem.Description}\n");
                        Console.WriteLine("[1] Nehmen");
                        Console.WriteLine("[2] Inventar öffnen");
                        Console.WriteLine("[3] Zurück");

                        Console.Write("[#]: ");
                        string selection = Console.ReadLine();
                        CheckedInput checkedInput = CheckUserInput(selection, 1, 3);
                        int selectedItemOption = checkedInput.Value;

                        if (!checkedInput.IsValid) { continue; }

                        if (selectedItemOption == 1)
                        {
                            player.AddItem(selectedItem);
                            loot.Remove(selectedItem);
                            Console.ReadLine();
                            break;
                        }
                        else if (selectedItemOption == 2)
                        {
                            player.DisplayInventory();
                            Console.ReadLine();
                        }
                        else { break; }
                    }
                }
                else if (selectedValue == loot.Count + 1)
                {
                    foreach (var item in loot)
                    {
                        player.AddItem(item);
                    }
                    Console.WriteLine("Alle Items wurden deinem Inventar hinzugefügt!");
                    loot.Clear();
                    Console.ReadLine();
                }
                else if (selectedValue == loot.Count + 2)
                {
                    break;
                }
            }
        }





        public static ConsoleColor GetRarityColor(Rarity rarity)
        {
            switch (rarity)
            {
                case Rarity.Common:
                    return ConsoleColor.White;
                case Rarity.Uncommon:
                    return ConsoleColor.Green;
                case Rarity.Rare:
                    return ConsoleColor.Blue;
                case Rarity.Epic:
                    return ConsoleColor.Magenta;
                case Rarity.Legendary:
                    return ConsoleColor.Yellow;
                case Rarity.Mythic:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.White;
            }
        }

    }
}
