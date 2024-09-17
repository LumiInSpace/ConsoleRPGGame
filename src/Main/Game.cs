
using ConsoleRPGGame.src.Events;
using System.Text.Json;

namespace ConsoleRPGGame.src.Main
{
    public class Game
    {
        public void Start()
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

            bool isValidInputShowInstructions = false;
            int playerResponseShowInstructions = 0;

            while (isValidInputShowInstructions == false)
            {
                Console.Clear();
                TypeText("Möchtest du direkt ins Spiel starten oder doch zuerst die Anleitung lesen?\n");
                Console.WriteLine();
                TypeText("[1] Anleitung anzeigen\n");
                TypeText("[2] Spiel Starten\n");
                Console.WriteLine();
                TypeText("[#]: ");

                bool wasSuccessful = int.TryParse(Console.ReadLine(), out playerResponseShowInstructions);
                if (wasSuccessful && playerResponseShowInstructions == 1 || playerResponseShowInstructions == 2)
                {
                    isValidInputShowInstructions = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Es ist ein Fehler aufgetreten. Bitte versuche es erneut!");
                    Console.ReadLine();
                }
            }

            if (playerResponseShowInstructions == 1) { ShowInstructions(); }

        }

        public void StartMainGame()
        {
            CommonChestEvent chestEvent = new CommonChestEvent();
            chestEvent.StartEvent();

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
                    Console.WriteLine("[2] Bandit  (Stärke: 11  Lebenspunkte: 9   Schadensresistenz: 12  Ausdauer: 14 Glück: 4)");
                    Console.WriteLine("[3] Krieger (Stärke: 14  Lebenspunkte: 9   Schadensresistenz: 14  Ausdauer: 11 Glück: 2");

                    Console.WriteLine("\n");
                    TypeText("[#]: ");
                    string userInputCharacterClass = Console.ReadLine();

                    if (CheckUserAnswer(userInputCharacterClass, 1, 3) == false)
                    {
                        throw new IllegalCharacterClassException("Fehlerhafte Eingabe");
                    }
                    else
                    {
                        isCharacterClass = true;
                        starterCharacterClass = int.Parse(userInputCharacterClass);
                    }
                }


                return starterCharacterClass switch
                {
                    1 => CharacterFactory.CreateCharacter(name, CharacterClass.Samurai),
                    2 => CharacterFactory.CreateCharacter(name, CharacterClass.Bandit),
                    3 => CharacterFactory.CreateCharacter(name, CharacterClass.Warrior),
                    _ => throw new IllegalCharacterClassException("Ausgewählte Charakterklasse nicht vorhanden!"),
                };
        }

        public static void ShowInstructions()
        {
            Console.WriteLine("Zurzeit ist keine Anleitung vorhanden :3");
        }
    }
}
