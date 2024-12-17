namespace ConsoleRPGGame.src.Utilitys
{
    public class ItemRandomizer
    {
        public int CommonProbability { get; set; }
        public int UncommonProbability { get; set; }
        public int RareProbability { get; set; }
        public int EpicProbability { get; set; }
        public int LegendaryProbability { get; set; }
        public int MythicProbability {  get; set; }


        public ItemRandomizer(int uncommonProbability, int commonProbability, int rareProbability, int epicProbability, int legendaryProbability, int mythicProbability)
        {
            CommonProbability = CommonProbability;
            UncommonProbability = uncommonProbability + commonProbability;
            RareProbability = uncommonProbability + commonProbability + rareProbability;
            EpicProbability = uncommonProbability + commonProbability + rareProbability + epicProbability;
            LegendaryProbability = uncommonProbability + commonProbability + rareProbability + epicProbability + legendaryProbability;
            MythicProbability = uncommonProbability + commonProbability + rareProbability + epicProbability + legendaryProbability + mythicProbability;
        }

        
        public Rarity GetItemRarity()
        {
            Random random = new Random();

            int randomInteger = random.Next(1, 101);

            if(randomInteger < UncommonProbability) { return Rarity.Uncommon; }
            else if(randomInteger >= UncommonProbability && randomInteger < RareProbability) { return Rarity.Common; }
            else if(randomInteger >= CommonProbability && randomInteger < EpicProbability) { return Rarity.Rare; }
            else if (randomInteger >= RareProbability && randomInteger < LegendaryProbability) { return Rarity.Epic; }
            else if (randomInteger >= EpicProbability && randomInteger < MythicProbability) { return Rarity.Legendary; }
            else { return Rarity.Mythic; }
        }

        public List<Item> GetLoot(Rarity rarity, List<Item> items)
        {
            List<Item> filteredItems = new List<Item>();

            switch (rarity) {
                
                case Rarity.Common:
                    filteredItems.AddRange(items.Where(x => x.Rarity == Rarity.Common));
                    return GetCommonLoot(filteredItems);
                default:
                    return filteredItems;
            } 
        }

        private List<Item> GetCommonLoot(List<Item> commonItems) 
        { 
            Random random = new Random();
            List<Item> loot = new List<Item>();

            loot.Add(commonItems[random.Next(commonItems.Count)]);

            return loot;
        }

    }
}
