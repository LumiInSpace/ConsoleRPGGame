using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.src.Main.Chests
{
    public class UncommonChest : Chest
    {
        public Dictionary<Rarity, float> DropRates { get; set; }

        public UncommonChest()
            : base(new Dictionary<Rarity, float>
            {
                { Main.Rarity.Common, 28f },
                { Main.Rarity.Uncommon, 50f },
                { Main.Rarity.Rare, 15f },
                { Main.Rarity.Epic, 5f },
                { Main.Rarity.Legendary, 2f },
                { Main.Rarity.Mythic, 0f }
            }, Rarity.Uncommon)
        {
        }
    }
}
