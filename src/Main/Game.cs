
using ConsoleRPGGame.src.Events;
using ConsoleRPGGame.src.Utilitys.Gui;

namespace ConsoleRPGGame.src.Main
{
    public class Game
    {
        public Character Start()
        {

            TypeText("Willkommen :D\n");
            Thread.Sleep(1500);
            TypeText("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.\n");

            Character player = GetCharakter();
            Console.WriteLine();

            TypeText($"Name: {player.Name}");
            Console.WriteLine();
            TypeText($"Klasse: {player.CharacterClass}");
            Console.WriteLine();
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Möchtest du direkt ins Spiel starten oder doch zuerst die Anleitung lesen?");
                Console.WriteLine();
                Console.WriteLine("[1] Anleitung anzeigen");
                Console.WriteLine("[2] Spiel Starten");
                Console.WriteLine("\n");
                TypeText("[#]: ");
                string playerResponseShowInstructions = Console.ReadLine();
                var checkedInput = CheckUserInput(playerResponseShowInstructions, 1, 2);

                if (checkedInput.IsValid == false)
                {
                    Console.Clear();
                }


                if (checkedInput.Value == 1)
                {
                    ShowInstructions();
                    return player;
                }
                else { return player; }
            }

        }

        public void StartMainGame(List<Item> items, Character player)
        {
            Console.Clear();
            Gui.ShowInfoBar();

            while (true)
            {
                var newEvent = EventTrigger.TriggerEvent();
                newEvent.StartEvent(items, player);
            }
        }

        public Character GetCharakter()
        {
            bool nameIsNull = true;
            string name = string.Empty;
            bool isCharacterClass = false;
            int starterCharacterClass = 0;

            while (nameIsNull)
            {
                Thread.Sleep(1000);
                TypeText("Lege einen Namen fest: ");
                name = Console.ReadLine();

                if (name != "")
                {
                    nameIsNull = false;
                }
            }

            while (isCharacterClass == false)
            {

                TypeText("Wähle deine Startklasse: \n");
                Console.WriteLine();

                Console.WriteLine("[1] Samurai (Stärke: 13  Lebenspunkte: 10  Schadensresistenz: 15  Ausdauer: 9  Glück: 3)");
                Console.WriteLine("[2] Bandit  (Stärke: 11  Lebenspunkte: 9  Schadensresistenz: 12  Ausdauer: 14  Glück: 4)");
                Console.WriteLine("[3] Warrior  (Stärke: 14  Lebenspunkte: 9  Schadensresistenz: 14  Ausdauer: 11  Glück: 2)");
                Console.WriteLine("[4] Beggar  (Stärke: 7  Lebenspunkte: 7  Schadensresistenz: 8  Ausdauer: 12  Glück: 6)");



                Console.WriteLine("\n");
                TypeText("[#]: ");
                string userInput = Console.ReadLine();

                try
                {
                    starterCharacterClass = int.Parse(userInput);
                    if (starterCharacterClass < 1 || starterCharacterClass > 4)
                    {
                        throw new Exception();
                    }

                    isCharacterClass = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Es ist ein Fehler aufgetreten. Versuche es erneut!");
                }
            }


            return starterCharacterClass switch
            {
                1 => CharacterFactory.CreateCharacter(name, CharacterClass.Samurai),
                2 => CharacterFactory.CreateCharacter(name, CharacterClass.Bandit),
                3 => CharacterFactory.CreateCharacter(name, CharacterClass.Warrior),
                4 => CharacterFactory.CreateCharacter(name, CharacterClass.Beggar),
                _ => throw new IllegalCharacterClassException("Ausgewählte Charakterklasse nicht vorhanden!"),
            };
        }

        public static void ShowInstructions()
        {
            Console.Clear();
            Console.WriteLine("Zurzeit ist keine Anleitung vorhanden :3");
            Console.ReadLine();
        }
    }
}
