using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.src.Main
{
    public class Chest
    {
        public Dictionary<Rarity, float> DropRates { get; set; }

        public Chest(Dictionary<Rarity, float> dropRates)
        {
            DropRates = dropRates;
        }
    }
}
