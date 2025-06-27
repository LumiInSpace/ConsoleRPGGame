
namespace ConsoleRPGGame.src.Utilitys
{
    public abstract class AnswerChecker
    {
        public static CheckedInput CheckUserInput(string userInput, int lowestPossibleValue, int highestPossibleValue)
        {
            bool isInteger = int.TryParse(userInput, out int userInputInt);

            if (isInteger == false) { return new CheckedInput(false, 0); }

            if (userInputInt < lowestPossibleValue || userInputInt > highestPossibleValue) { return new CheckedInput(false, 0); }

            return new CheckedInput(true, userInputInt);
        }
    }
}
