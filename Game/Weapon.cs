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
        public double Multiplier { get; set; }
        public int SpecialAttackDamage { get; set; }

        public Weapon(string name, int damage, double multiplier, int specialAttackDamage)
        {
            Name = name;
            Damage = damage;
            Multiplier = multiplier;
            SpecialAttackDamage = specialAttackDamage;
        }

        public virtual void lightAttack()
        {
            Console.WriteLine($"({Name}) Leichter Angriff! Schaden: {Damage}");
        }

        public virtual void heavyAttack()
        {
            Console.WriteLine($"({Name}) Starker Angriff! Schaden: {Damage * Multiplier}");
        }

        public virtual void specialAttack()
        {
            Console.WriteLine($"({Name}) !SPECIAL ATTACKE! Schaden: {SpecialAttackDamage}");
        }
    }
}
