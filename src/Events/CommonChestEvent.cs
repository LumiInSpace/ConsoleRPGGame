namespace ConsoleRPGGame.src.Events
{
    public class CommonChestEvent : IEvent 
    {
        public void StartEvent()
        {
            Random random = new Random();
            
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
            bool isOk = CheckUserAnswer(userInput, 1, 2);

            if (!isOk)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                TypeText("Es ist ein Fehler aufgetreten versuche es erneut!\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                TypeText("Press ENTER\n");
                Console.ReadLine();
                StartEvent();
            }

            if (isOk)
            {
                int userInputInt = int.Parse(userInput);
                
                if (userInputInt == 1) 
                {
                    TypeText("Noch kein Inhalt!");
                }
            }
        }
    }
}
