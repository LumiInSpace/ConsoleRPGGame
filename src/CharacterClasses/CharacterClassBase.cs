namespace ConsoleRPGGame.src.CharacterClasses
{
    public abstract class CharacterClassBase
    {
        public int Strenght { get; set; }

        public int HP { get; set; }

        public int Resistance { get; set; }

        public int Luck { get; set; }

        public int Endurance { get; set; }


        public CharacterClassBase(int strenght, int hp, int resistance, int luck, int endurance)
        {
            Strenght = strenght;
            HP = hp;
            Resistance = resistance;
            Luck = luck;
            Endurance = endurance;
        }
    }
}
