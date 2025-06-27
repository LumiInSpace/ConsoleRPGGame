using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.src.Main.Chests
{
    public class RareChest : Chest
    {
        public Dictionary<Rarity, float> DropRates { get; set; }

        public RareChest()
            : base(new Dictionary<Rarity, float>
            {
                { Rarity.Common, 18f },
                { Rarity.Uncommon, 28f },
                { Rarity.Rare, 50f },
                { Rarity.Epic, 10f },
                { Rarity.Legendary, 4f },
                { Rarity.Mythic, 0f }
            }, Rarity.Rare)
        {
        }
    }
}
