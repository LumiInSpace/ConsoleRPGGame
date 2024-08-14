
namespace ConsoleRPGGame.src.Weapons
{
    public class Fists : Weapon
    {
        public Fists() : base("Fäuste", 2, 3, 14)
        {

        }
        public override void LightAttack()
        {
            base.LightAttack();
            Console.WriteLine($"({Name}) Leichter Faustschlag! Schaden: {Damage}");
        }

        public override void HeavyAttack()
        {
            base.HeavyAttack();
            Console.WriteLine($"({Name})Starker Faustschlag! Schaden: {Damage * Multiplier}");
        }

        public override void SpecialAttack()
        {
            base.SpecialAttack();
            Console.WriteLine($"({Name}) ANSTURM DER FÄUSTE! Schaden: {SpecialAttackDamage}");
        }
    }
}
