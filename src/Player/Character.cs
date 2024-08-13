
namespace ConsoleRPGGame.src.Player
{
    public class Character
    {
        public CharacterClass CharacterClass { get; set; } = new Samurai();

        public string Name { get; set; } = string.Empty;

        public Weapon EquippedWeapon { get; set; }

        public int Strenght { get; set; }

        public int Resistance { get; set; }

        public int EndurancePoints { get; set; }

        public int Luck { get; set; }

        public string CharacterPresetTyp { get; set; }

        public int HPPoints { get; set; }

        public int HP {  get; set; }


        public Character(string name, CharacterClass characterClass)
        {
            Name = name;
            CharacterClass = new Samurai();
            EquippedWeapon = new Fists();
            Strenght = characterClass.Strenght;
            Resistance = characterClass.Resistance;
            EndurancePoints = characterClass.Endurance;
            Luck = characterClass.Luck;
            CharacterPresetTyp = characterClass.Name;
            HPPoints = characterClass.HP;
            HP = characterClass.HP * 10;
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
