
using ConsoleRPGGame.src.Player;

namespace ConsoleRPGGame.src.Main
{
    public class Game
    {
        public void Start()
        {
            typeText("Willkommen :D\n");
            Thread.Sleep(1500);
            typeText("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.\n");

            Character player = GetCharakter();
            Console.WriteLine();

            typeText($"Name: {player.Name}");
            Console.WriteLine();
            typeText($"Klasse: {player.CharacterClass.Name}");
            Console.WriteLine();
            Console.ReadLine();

            bool isValidInputShowInstructions = false;
            int playerResponseShowInstructions = 0;

            while (isValidInputShowInstructions == false)
            {
                Console.Clear();
                Console.WriteLine("Möchtest du direkt ins Spiel starten oder doch zuerst die Anleitung lesen?");
                Console.WriteLine();
                Console.WriteLine("[1] Anleitung anzeigen");
                Console.WriteLine("[2] Spiel Starten");

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

            if (playerResponseShowInstructions == 1) { showInstructions(); }


        }

        public void startMainGame()
        {

        }

        public Character GetCharakter()
        {
            bool nameIsNull = true;
            string name = null;
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

            while (isCharacterClass == false) {

                typeText("Wähle deine Startklasse: \n");
                Console.WriteLine();

                Console.WriteLine("[1] Samurai (Stärke: 15  Lebenspunkte: 12  Schadensresistenz: 17  Glück: 4) ");
                Console.WriteLine("[2] Bandit  ()");

                isCharacterClass = int.TryParse(Console.ReadLine(), out starterCharacterClass);

                if (isCharacterClass == false || starterCharacterClass < 1 || starterCharacterClass > 2) 
                { 
                    Console.WriteLine("Es ist ein Fehler aufgetreten. Versuche es erneut!"); 
                }
            }

            CharacterClass characterClass = null;
            
            switch (starterCharacterClass)
            {
                case 1:
                    characterClass = new Samurai();
                    break;
            }

            return new(name, characterClass);
        }

        public static void showInstructions()
        {
            Console.WriteLine("Zurzeit ist keine Anleitung vorhanden :3");
        }
    }
}
