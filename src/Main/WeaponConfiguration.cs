
namespace ConsoleRPGGame.src.Main
{
    public class WeaponConfiguration(int damage, double multiplier, int specialAttackDamage,
        bool hasSpecialAttack, string name, string description, string rarenessText,
        int rarenessNumber, int maxValue)
    {
        public int Damage { get; set; } = damage;
        public double Multiplier { get; set; } = multiplier;
        public int SpecialAttackDamage { get; set; } = specialAttackDamage;
        public bool HasSpecialAttack { get; set; } = hasSpecialAttack;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string RarenessText { get; set; } = rarenessText;
        public int RarenessNumber { get; set; } = rarenessNumber;
        public int MaxValue { get; set; } = maxValue;
    }
}
