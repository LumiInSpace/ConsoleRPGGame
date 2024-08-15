
namespace ConsoleRPGGame.src.Weapons
{
    public class Fists : Weapon, IDamageSource
    {
        public Fists() : base(new WeaponConfiguration(2, 3, 14, true, "Fäuste", "Keine Beschreibung vorhanden", "gewoehnlich", 1, 1))
        {

        }

        public override void LightAttack()
        {
            Console.WriteLine($"({Name}) Leichter Faustschlag! Schaden: {Damage}");
        }

        public override void HeavyAttack()
        {
            Console.WriteLine($"({Name})Starker Faustschlag! Schaden: {Damage * Multiplier}");
        }

        public override void SpecialAttack()
        {
            if (HasSpecialAttack)
            {
                Console.WriteLine($"({Name}) ANSTURM DER FÄUSTE! Schaden: {SpecialAttackDamage}");
            }

            Console.WriteLine("Ausgerüstete Waffe hat keine Spezialattacke!");
        }
    }
}
