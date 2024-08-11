using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.Weapons
{
    public class Bow : Weapon
    {
        public double Range { get; set; }

        public Bow() : base("Bogen", 17, 2.0)
        {
        }

        public override void lightAttack()
        {
            base.lightAttack();
            Console.WriteLine($"({Name}) Bogenschuss! Schaden: {Damage}");
        }

        public override void heavyAttack()
        {
            base.heavyAttack();
            Console.WriteLine($"({Name})Starker Bogenschuss! Schaden: {Damage * Multiplier}");
        }
    }
}