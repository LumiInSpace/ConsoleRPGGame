namespace ConsoleRPGGame.src.Player
{
    public class Equipment
    {
        public Item? MainHand { get; private set; } = null;

        public Item? OffHand { get; private set; } = null;

        public Item DefaultWeapon { get; } = new Weapon(0, "Fäuste", "Standard Waffe", Rarity.None, 0, ItemCategory.Weapon, 5, 5, 25, true, "Ansturm der Fäuste", "Der Spieler greift den Gegner mit 5 schnellen Schlägen an. So schnell das man diesen Angriff nicht blockieren kann.");

        public Equipment()
        {
            MainHand = DefaultWeapon;
        }

        public bool EquipItem(Item item)
        {
            switch (item.Category)
            {
                case ItemCategory.Weapon:
                    MainHand = item;
                    Console.WriteLine($"{item.Name} wurde als Waffe ausgerüstet!");
                    return true;
                case ItemCategory.Shield:
                    OffHand = item;
                    Console.WriteLine($"{item.Name} wurde als Schild ausgerüstet!");
                    return true;
                default:
                    Console.WriteLine($"{item.Name} kann nicht ausgerüstet werden!");
                    return false;
            }
        }

        public Item GetEquippedWeapon()
        {
            return MainHand ?? DefaultWeapon;
        }
    }
}
