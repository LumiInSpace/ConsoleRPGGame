using ConsoleRPGGame.src.CharacterClasses.Exceptions;

namespace ConsoleRPGGame.src.CharacterClasses
{
    public static class CharacterFactory
    {
        public static Character CreateCharacter(string characterName, CharacterClass characterClass)
        {
            return (characterClass) switch
            {
                CharacterClass.Bandit => CreateDefaultBandit(characterName),
                CharacterClass.Samurai => CreateDefaultSamurai(characterName),
                _ => throw new UnsupportedCharacterClassException("Die angegebene Spielerklasse wird nicht unterstützt")
            };
        }

        private static Character CreateDefaultBandit(string characterName)
            => new Character(new CharacterConfiguration(CharacterClass.Bandit, characterName, 11, 9, 12, 14, 4));

        private static Character CreateDefaultSamurai(string characterName)
            => new Character(new CharacterConfiguration(CharacterClass.Samurai, characterName, 13, 10, 15, 9, 3));

        //private static CharacterClass CreateDefaultBandit()
        //    => new Warrior(11, 9, 12, 14, 4, "Bandit");
    }
}
