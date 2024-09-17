
using ConsoleRPGGame.src.Events;

namespace ConsoleRPGGame.src.Main
{
    public class Game
    {
        public void Start()
        {
            try
            {
                TypeText("Willkommen :D\n");
                Thread.Sleep(1500);
                TypeText("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.\n");

                Character player = GetCharakter();
                Console.WriteLine();

            typeText($"Name: {player.Name}");
            Console.WriteLine();
            typeText($"Klasse: {player.CharacterClass}");
            Console.WriteLine();
            Console.ReadLine();

                

            while (isValidInputShowInstructions == false)
            {
                Console.Clear();
                Console.WriteLine("Möchtest du direkt ins Spiel starten oder doch zuerst die Anleitung lesen?");
                Console.WriteLine();
                Console.WriteLine("[1] Anleitung anzeigen");
                Console.WriteLine("[2] Spiel Starten");

                    if (CheckUserAnswer(playerResponseShowInstructions, 1, 2) == false)
                    {
                        Console.Clear();
                        throw new InvalidUserInputException("Fehlerhafte Eingabe!");
                    }
                    

                    if (int.Parse(playerResponseShowInstructions) == 1) { ShowInstructions(); }
                    else { break; }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
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
                typeText("Lege einen Namen fest: ");
                name = Console.ReadLine();

                    if (name != "")
                    {
                        nameIsNull = false;
                    }
                }

                while (isCharacterClass == false)
                {

                typeText("Wähle deine Startklasse: \n");
                Console.WriteLine();

                Console.WriteLine("[1] Samurai (Stärke: 13  Lebenspunkte: 10  Schadensresistenz: 15  Ausdauer: 9  Glück: 3)");
                Console.WriteLine("[2] Bandit  (Stärke: 11  Lebenspunkte: 9  Schadensresistenz: 12  Ausdauer: 14  Glück: 4)");

                    Console.WriteLine("\n");
                    TypeText("[#]: ");
                    string userInputCharacterClass = Console.ReadLine();

                if (isCharacterClass == false || starterCharacterClass < 1 || starterCharacterClass > 2) 
                { 
                    Console.WriteLine("Es ist ein Fehler aufgetreten. Versuche es erneut!"); 
                }
            }


            return starterCharacterClass switch
            {
                1 => CharacterFactory.CreateCharacter(name, CharacterClass.Samurai),
                2 => CharacterFactory.CreateCharacter(name, CharacterClass.Bandit),
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
