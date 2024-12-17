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


            ItemRandomizer randomizer = new(70, 20, 5, 3, 2, 0);
            Rarity itemRarity = randomizer.GetItemRarity();

            List<Item> loot = randomizer.GetLoot(Main.Rarity.Common, items);
            Console.WriteLine("Du hast folgende Items erhalten: ");

            foreach (Item item in loot)
            {
                
                Console.WriteLine(item.Name);
            }

        }
    }
}