using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame
{
    public class Charakter
    {
        public string Name { get; set; } = string.Empty;
        public string? Age { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public int HP { get; set; } = 100;
        public int Endurance { get; set; } = 100;
        public string ClassName { get; set; }

        public Charakter(string name, string age)
        {
            Name = name;
            Age = age;
            CurrentWeapon = new WoodenSword();
            ClassName = "Krieger";
        }

    }
}
