using static ConsoleRPGGame.TypeText;

namespace ConsoleRPGGame
{
    public class Game
    {
        public void Start() 
        {
            typeText("Willkommen!\n");
            Thread.Sleep(2000);
            typeText("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.\n");
            

            Charakter player = GetCharakter();
            Console.WriteLine();

            typeText(player.Name);
            Console.WriteLine();
            typeText(player.Age);
            Console.WriteLine();
            typeText(player.ClassName);
            Console.WriteLine();
        }

        public Charakter GetCharakter()
        {
            bool nameIsNull = true;
            string name = null;
            string age = string.Empty;

            while (nameIsNull) {

                Thread.Sleep(1000);
                typeText("Lege einen Namen fest: ");
                name = Console.ReadLine() ;
                
                if (name != "")
                { 
                    nameIsNull = false ; 
                }
            }

            Thread.Sleep(1000);
            typeText("Lege das Alter fest (optional): ");
            age = Console.ReadLine();

            if (age == "") { age = "-"; }

            return new(name, age);
        }
    }
}
