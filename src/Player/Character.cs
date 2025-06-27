
namespace ConsoleRPGGame.src.Player
{
    public class Character
    {
        public CharacterClass CharacterClass { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Strenght { get; set; }

        public int Resistance { get; set; }

        public int Luck { get; set; }

        public int HP {  get; set; }

        public int Endurance { get; set; }

        public int SkillPoints { get; set; } = 0;

        public Inventory Inventory { get; private set; } = new Inventory();

        public Equipment Equipment { get; set; } = new Equipment();


        public Character(CharacterConfiguration characterConfig)
        {
            Name = characterConfig.CharacterName;
            CharacterClass = characterConfig.CharacterClass;
            Strenght = characterConfig.Strenght;
            Resistance = characterConfig.Resistance;
            Luck = characterConfig.Luck;
            HP = characterConfig.HP * 10;
            Endurance = characterConfig.Endurance * 10;
        }

        public int UseLightAttack()
        {
            Item equipedItem = Equipment.GetEquippedWeapon();

            if (equipedItem is Weapon equipedWeapon)
            {
                return (int)Math.Round(equipedWeapon.Damage + (Strenght * 0.25));
            }

            Console.WriteLine("Es ist ein Fehler aufgetreten! Ausgerüstete Waffe ist keine Waffe.");
            Console.WriteLine("Dieser Fehler sollte nicht auftreten können, falls doch dann melde diesen Fehler umgegehend.");
            return 0;
        }

        public int UseHeavyAttack()
        {
            Item equipedItem = Equipment.GetEquippedWeapon();

            if (equipedItem is Weapon equipedWeapon)
            {
                return (int)Math.Round((equipedWeapon.Damage * equipedWeapon.Multiplier) + (Strenght * 0.25));
            }

            Console.WriteLine("Es ist ein Fehler aufgetreten! Ausgerüstete Waffe ist keine Waffe.");
            Console.WriteLine("Dieser Fehler sollte nicht auftreten können, falls doch dann melde diesen Fehler umgegehend.");
            return 0;
        }

        public int UseSpecialAttack()
        {
            Item equipedItem = Equipment.GetEquippedWeapon();

            if (equipedItem is Weapon equipedWeapon)
            {
                Console.WriteLine(equipedWeapon.SpecialAttackName);
                return (int)Math.Round(equipedWeapon.SpecialAttackDamage * (Strenght * 0.25));
            }

            Console.WriteLine("Es ist ein Fehler aufgetreten! Ausgerüstete Waffe ist keine Waffe.");
            Console.WriteLine("Dieser Fehler sollte nicht auftreten können, falls doch dann melde diesen Fehler umgegehend.");
            return 0;
        }

        public bool AddItem(Item item)
        {
            return Inventory.AddItem(item);
        }

        public bool RemoveItem(Item item)
        {
            return Inventory.RemoveItem(item);
        }

        public void DisplayInventory()
        {
            Inventory.DisplayItems();
        }
    }
}
