using ConsoleRPGGame.CharacterClasses;

namespace ConsoleRPGGame.Player
{
    public class Character
    {
        public CharacterClass CharacterClass { get; set; } = new Samurai();

        public string Name { get; set; } = string.Empty;
        
        public Weapon EquippedWeapon { get; set; }

        public int Strenght { get; set; }

        public int Resistance { get; set; }

        public int Endurance { get; set; }

        public int Luck { get; set; }

        public string CharacterPresetTyp { get; set; }


        public Character(string name, CharacterClass characterClass)
        {
            Name = name;
            CharacterClass = new Samurai();
            EquippedWeapon = new Fists();
            Strenght = characterClass.Strenght;
            Resistance = characterClass.Resistance;
            Endurance = characterClass.Endurance;
            Luck = characterClass.Luck;
            CharacterPresetTyp = characterClass.Name;
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
