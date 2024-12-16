
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

        public int HP {  get; set; }

        public int Endurance { get; set; }

        public int SkillPoints { get; set; } = 0;


        public Character(CharacterConfiguration characterConfig)
        {
            Name = characterConfig.CharacterName;
            CharacterClass = characterConfig.CharacterClass;
            EquippedWeapon = new Fists();
            Strenght = characterConfig.Strenght;
            Resistance = characterConfig.Resistance;
            Luck = characterConfig.Luck;
            HP = characterConfig.HP * 10;
            Endurance = characterConfig.Endurance * 10;
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

        public void useHeavyAttack()
        {
            if (EquippedWeapon != null)
            {
                EquippedWeapon.HeavyAttack();
            }
            else
            {
                Console.WriteLine("Keine Waffe ausgerüstet");
            }
        }

        public void useSpecialAttack()
        {
            if (EquippedWeapon != null)
            {
                EquippedWeapon.SpecialAttack();
            }
            else
            {
                Console.WriteLine("Keine Waffe ausgerüstet");
            }
        }
    }
}
