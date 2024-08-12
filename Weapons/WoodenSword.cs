using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.Weapons
{
    public class WoodenSword : Weapon
    {
        public double Range { get; set; } = 1.5;

        public WoodenSword() : base("Holzschwert", 12, 1.2, 32)
        {
        }
    }
}
