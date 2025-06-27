using ConsoleRPGGame.src.Interfaces;
using System.Text.Json.Serialization;

namespace ConsoleRPGGame.src.Main
{
    public class Weapon : Item, IDamageSource
    {
        public int Damage { get; set; }
        public double Multiplier { get; set; }
        public int SpecialAttackDamage { get; set; }
        public bool HasSpecialAttack { get; set; }
        public string SpecialAttackName { get; set; }
        public string SpecialAttackDescription { get; set; }

        [JsonConstructor]
        public Weapon(int id, string name, string description, Rarity rarity, int maxValue,
                  ItemCategory category, int damage, double multiplier, int specialAttackDamage, bool hasSpecialAttack, string specialAttackName,
                  string specialAttackDescription) : base(name, description, rarity, maxValue, category) 
        {
            Damage = damage;
            Multiplier = multiplier;
            SpecialAttackDamage = specialAttackDamage;
            HasSpecialAttack = hasSpecialAttack;
            SpecialAttackName = specialAttackName;
            SpecialAttackDescription = specialAttackDescription;
        }
        
        public virtual void LightAttack()
        {
            Console.WriteLine($"({Name}) Leichter Angriff! Schaden: {Damage}");
        }

        public virtual void HeavyAttack()
        {
            Console.WriteLine($"({Name})Starker Angriff! Schaden: {Damage * Multiplier}");
        }

        public virtual void SpecialAttack()
        {
            if (HasSpecialAttack)
            {
                Console.WriteLine($"({Name}) SPEZIALATTACKE! Schaden: {SpecialAttackDamage}");
            }
            else
            { 
                Console.WriteLine("Ausgerüstete Waffe hat keine Spezialattacke!");
            }

        }
    }
}
