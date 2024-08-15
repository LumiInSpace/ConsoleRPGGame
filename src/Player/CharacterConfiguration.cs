namespace ConsoleRPGGame.src.Player
{
    public class CharacterConfiguration(CharacterClass characterClass, string name, int strenght, int hP, int resistance, int luck, int endurance)
    {
        public CharacterClass CharacterClass { get; set; } = characterClass;
        
        public string CharacterName { get; set; } = name;
        
        public int Strenght { get; set; } = strenght;

        public int HP { get; set; } = hP;

        public int Resistance { get; set; } = resistance;

        public int Luck { get; set; } = luck;

        public int Endurance { get; set; } = endurance;
    }


}
