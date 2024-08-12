namespace ConsoleRPGGame.Player
{
    public class Charakter
    {
        public string Name { get; set; } = string.Empty;
        public string Age { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int HP { get; set; } = 100;
        public int Endurance { get; set; } = 100;
        public string ClassName { get; set; }

        public Charakter(string name, string age)
        {
            Name = name;
            Age = age;
            EquippedWeapon = new WoodenSword();
            ClassName = "Krieger";
        }

        public void useLightAttack()
        {
            if (EquippedWeapon != null)
            {
                EquippedWeapon.lightAttack();
            }
            else
            {
                Console.WriteLine("Keine Waffe ausgerüstet");
            }
        }

    }
}
