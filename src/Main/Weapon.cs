using ConsoleRPGGame.src.Interfaces;

namespace ConsoleRPGGame.src.Main
{
    public class Weapon : Item, IDamageSource
    {
        public int Damage { get; set; }
        public double Multiplier { get; set; }
        public int SpecialAttackDamage { get; set; }
        public bool HasSpecialAttack { get; set; }

        public Weapon(WeaponConfiguration config) : base(config.Name, config.Description, config.RarenessText, config.RarenessNumber, config.MaxValue) 
        {
            Damage = config.Damage;
            Multiplier = config.Multiplier;
            SpecialAttackDamage = config.SpecialAttackDamage;
            HasSpecialAttack = config.HasSpecialAttack;
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

            Console.WriteLine("Ausgerüstete Waffe hat keine Spezialattacke!");
        }
    }
}
