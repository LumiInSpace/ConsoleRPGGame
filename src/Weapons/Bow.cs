namespace ConsoleRPGGame.src.Weapons
{
    public class Bow : Weapon
    {
        public Bow() : base(new WeaponConfiguration(17, 2.0, 54, true, "Dieter", "Krasser Ballermann", "Mythic+", 123, 1))
        {
            
        }

        public Bow(WeaponConfiguration config) : base(config)
        {
            
        }

        public override void LightAttack()
        {
            Console.WriteLine($"({Name}) Leichter Bogenschuss! Schaden: {Damage}");
        }

        public override void HeavyAttack()
        {
            Console.WriteLine($"({Name}) Starker Bogenschuss! Schaden: {Math.Round(Damage * Multiplier)}");
        }

        public override void SpecialAttack()
        {
            if (HasSpecialAttack)
            {
                Console.WriteLine($"({Name}) PFEILHAGEL! Schaden: {SpecialAttackDamage}");
            }

            Console.WriteLine("Ausgerüstete Waffe hat keine Spezialattacke!");
        }
    }
}