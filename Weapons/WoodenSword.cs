namespace ConsoleRPGGame.Weapons
{
    public class WoodenSword : Weapon
    {
        public double Range { get; set; } = 1.5;

        public WoodenSword() : base("Holzschwert", 12, 1.2, 32)
        {
        }
    }
}
