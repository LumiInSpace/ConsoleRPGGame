using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.Weapons
{
    public class WoodenSword : Weapon
    {
        public double Range { get; set; }

        public WoodenSword() : base("Holzschwert", 17, 1.2)
        {
        }
    }
}
