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
        private string Name { get; set; } = string.Empty;
        private string? Age { get; set; }
        private Weapon CurrentWeapon { get; set; }
        private int HP { get; set; } = 100;
        private int endurance { get; set; } = 100;
        private string ClassName { get; set; }

        public Charakter(string name, string age)
        {
            Name = name;
            Age = age;
            CurrentWeapon = new WoodenSword();
            ClassName = "Krieger";
        }

    }
}
