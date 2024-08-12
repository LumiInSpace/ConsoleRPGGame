namespace ConsoleRPGGame.Main
{
    public class Game
    {
        public void Start()
        {
            typeText("Willkommen :D\n");
            Thread.Sleep(2000);
            typeText("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.\n");

            Charakter player = GetCharakter();
            Console.WriteLine();

            typeText($"Name: {player.Name}");
            Console.WriteLine();
            typeText($"Alter: {player.Age}");
            Console.WriteLine();
            typeText($"Klasse: {player.ClassName}");
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

        public Charakter GetCharakter()
        {
            bool nameIsNull = true;
            string name = null;
            string age = string.Empty;

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

            Thread.Sleep(1000);
            typeText("Lege das Alter fest (optional): ");
            age = Console.ReadLine();

            if (age == "") { age = "-"; }

            return new(name, age);
        }

        public static void showInstructions()
        {
            Console.WriteLine("Zurzeit ist keine Anleitung vorhanden :3");
        }
    }
}
