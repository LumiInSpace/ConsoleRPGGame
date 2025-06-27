
namespace ConsoleRPGGame.src.Main
{
    public class WeaponConfiguration(int damage, double multiplier, int specialAttackDamage,
        bool hasSpecialAttack, string name, string description, Rarity rarity, int maxValue)
    {
        public int Damage { get; set; } = damage;
        public double Multiplier { get; set; } = multiplier;
        public int SpecialAttackDamage { get; set; } = specialAttackDamage;
        public bool HasSpecialAttack { get; set; } = hasSpecialAttack;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public Rarity Rarity { get; set; } = rarity;
        public int MaxValue { get; set; } = maxValue;
        public ItemCategory Category { get; set; }
    }
}
