namespace ConsoleRPGGame.src.Player
{
    public class CharacterConfiguration(CharacterClass characterClass, string name, int strenght, int hP, int resistance, int endurance, int luck)
    {
        public CharacterClass CharacterClass { get; set; } = characterClass;
        
        public string CharacterName { get; set; } = name;
        
        public int Strenght { get; set; } = strenght;

        public int HP { get; set; } = hP;

        public int Resistance { get; set; } = resistance;

        public int Endurance { get; set; } = endurance;
        
        public int Luck { get; set; } = luck;
    }


}
