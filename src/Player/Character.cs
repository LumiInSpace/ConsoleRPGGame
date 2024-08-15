
namespace ConsoleRPGGame.src.Player
{
    public class Character
    {
        public CharacterClass CharacterClass { get; set; }

        public string Name { get; set; } = string.Empty;

        public Weapon EquippedWeapon { get; set; }

        public int Strenght { get; set; }

        public int Resistance { get; set; }

        public int EndurancePoints { get; set; }

        public int Luck { get; set; }

        public int HPPoints { get; set; }

        public int HP {  get; set; }
        public int Endurance { get; set; }


        public Character(CharacterConfiguration characterConfig)
        {
            Name = characterConfig.CharacterName;
            CharacterClass = characterConfig.CharacterClass;
            EquippedWeapon = new Fists();
            Strenght = characterConfig.Strenght;
            Resistance = characterConfig.Resistance;
            EndurancePoints = characterConfig.Endurance;
            Luck = characterConfig.Luck;
            HPPoints = characterConfig.HP;
            HP = HPPoints * 10;
            Endurance = EndurancePoints * 10;
        }

        public void useLightAttack()
        {
            if (EquippedWeapon != null)
            {
                EquippedWeapon.LightAttack();
            }
            else
            {
                Console.WriteLine("Keine Waffe ausgerüstet");
            }
        }

    }
}
