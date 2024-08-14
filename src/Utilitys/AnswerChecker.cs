
namespace ConsoleRPGGame.src.Utilitys
{
    public abstract class AnswerChecker
    {
        public static bool CheckUserAnswer(string userInput, int lowestPossibleValue, int highestPossibleValue)
        {
            bool isInteger = int.TryParse(userInput, out int userInputInt);

            if (isInteger == false) { return false; }

            if (userInputInt < lowestPossibleValue || userInputInt > highestPossibleValue) { return false; }

            return true;
        }
    }
}
