namespace ConsoleRPGGame.Weapons
{
    public class Fist : Weapon
    {
        public Fist() : base("Fäuste", 2, 3, 14)
        { 

        }
        public override void lightAttack()
        {
            base.lightAttack();
            Console.WriteLine($"({Name}) Leichter Faustschlag! Schaden: {Damage}");
        }

        public override void heavyAttack()
        {
            base.heavyAttack();
            Console.WriteLine($"({Name})Starker Faustschlag! Schaden: {Damage * Multiplier}");
        }

        public override void specialAttack()
        {
            base.specialAttack();
            Console.WriteLine($"({Name}) ANSTURM DER FÄUSTE! Schaden: {SpecialAttackDamage}");
        }
    }
}
