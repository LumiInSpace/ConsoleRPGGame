using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame
{
    public class Game
    {
        public void Start() 
        {
            Console.WriteLine("Willkommen!");
            Console.WriteLine("Bevor du beginnen kannst musst du erst deinen Charakter erstellen.");

            Charakter myCharakter = GetCharakter();
        }

        public Charakter GetCharakter()
        {
            bool nameIsNull = true;
            string name = string.Empty;

            while (nameIsNull) {

                Console.Write("Lege einen Namen fest: ");
                name = Console.ReadLine() ;
                if (name is not null) { nameIsNull = false ; }
            }

            Console.WriteLine("Lege das Alter fest (optional): ");
            string age = Console.ReadLine() ;

            return new(name, age);
        }
    }
}
