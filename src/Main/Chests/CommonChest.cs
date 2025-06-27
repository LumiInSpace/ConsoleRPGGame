namespace ConsoleRPGGame.src.Main.Chests
{
    public class CommonChest : Chest
    {
        public CommonChest()
            : base(new Dictionary<Rarity, float>
            {
                { Rarity.Common, 70f },
                { Rarity.Uncommon, 20f },
                { Rarity.Rare, 8f },
                { Rarity.Epic, 2f },
                { Rarity.Legendary, 0.5f },
                { Rarity.Mythic, 0f }
            }, Rarity.Common)
        {
        }
    }
}
