namespace ConsoleRPGGame.src.Utilitys
{
    public abstract class TypeText
    {
        public static void typeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
        }
    }
}
