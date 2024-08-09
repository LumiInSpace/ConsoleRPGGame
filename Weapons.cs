using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame
{
    public class Weapons() { }

    public class Bow : Weapon
    {
        public Bow() : base("Bogen", 17)
        { 
        }

        public override void lightAttack()
        {
            base.lightAttack();
            Console.WriteLine($"({Name}) Bogenschuss! Damage: {Damage}");
        }
    }

    public class Dolch : Weapon
    {
        private double Range { get; set; }

        public Dolch() : base("Dolch", 22)
        {
            Range = 1;
        }

        public override void lightAttack()
        {
            base.lightAttack();
            Console.WriteLine($"({Name}) Bogenschuss! Damage: {Damage}");
        }
    }
    public class WoodenSword : Weapon
    {
        private double Range { get; set; }

        public WoodenSword() : base("Holzschwert", 12)
        {
            Range = 1.5;
        }
    }
}
