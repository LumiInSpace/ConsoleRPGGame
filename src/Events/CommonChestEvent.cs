namespace ConsoleRPGGame.src.Events
{
    public class CommonChestEvent : Event
    {
        public override void StartEvent(List<Item> items, Character player)
        {


            TypeText("Du hast eine gewöhnliche Truhe gefunden!");
            Console.WriteLine("\n");
            Console.WriteLine("         __________\r\n        /\\____;;___\\\r\n       | /         /\r\n       `. ())oo() .\r\n        |\\(%()*^^()^\\\r\n       %| |-%-------|\r\n      % \\ | %  ))   |\r\n      %  \\|%________|"); //Truhe ASCII Art
            Console.WriteLine("\n");
            TypeText("Truhe öffnen?\n");
            TypeText("[1] Ja!\n");
            TypeText("[2] Nein!\n");
            Console.WriteLine();
            TypeText("[#]: ");
            string userInput = Console.ReadLine();
            CheckedInput checkedInput = CheckUserInput(userInput, 1, 2);

            if (checkedInput.IsValid == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                TypeText("Es ist ein Fehler aufgetreten versuche es erneut!\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                TypeText("Press ENTER\n");
                Console.ReadLine();
                StartEvent(items, player);
            }


            var commonChest = new Chest(new Dictionary<Rarity, float>
            {
                { Main.Rarity.Common, 70f },
                { Main.Rarity.Uncommon, 20f },
                { Main.Rarity.Rare, 8f },
                { Main.Rarity.Epic, 2f },
                { Main.Rarity.Legendary, 0.5f },
                { Main.Rarity.Mythic, 0f }
            });

            List<Item> loot = LootRandomizer.GetLoot(commonChest, items, 3);

            Console.WriteLine("Du hast folgende Items erhalten: ");

            foreach (Item item in loot)
            {

                Console.WriteLine(item.Name);
            }

        }
    }
}