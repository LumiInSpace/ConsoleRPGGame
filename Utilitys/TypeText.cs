namespace ConsoleRPGGame.Utilitys
{
    public class TypeText
    {
        public static void typeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }
    }
}
