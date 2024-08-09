using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame
{
    public class Weapon
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public virtual void lightAttack()
        {
            Console.WriteLine($"({Name})Leichter Angriff! Schaden: {Damage}");
        }
    }
}
