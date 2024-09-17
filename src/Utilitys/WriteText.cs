namespace ConsoleRPGGame.src.Utilitys
{
    public abstract class WriteText
    {
        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
        }
    }
}
