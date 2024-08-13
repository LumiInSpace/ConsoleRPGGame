using ConsoleRPGGame.src.Main;

namespace ConsoleRPGGame.src.Weapons
{
    public class Bow : Weapon
    {
        public double Range { get; set; }

        public Bow() : base("Bogen", 17, 2.0, 64)
        {
        }

        public override void lightAttack()
        {
            base.lightAttack();
            Console.WriteLine($"({Name}) Bogenschuss! Schaden: {Damage}");
        }

        public override void heavyAttack()
        {
            base.heavyAttack();
            Console.WriteLine($"({Name}) Starker Bogenschuss! Schaden: {Damage * Multiplier}");
        }

        public override void specialAttack()
        {
            base.specialAttack();
            Console.WriteLine($"({Name}) PFEILHAGEL! Schaden: {SpecialAttackDamage}");
        }
    }
}