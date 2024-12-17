namespace ConsoleRPGGame.src.Utilitys
{
    public abstract class TextWriter
    {
        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);

                if(SpinWait.SpinUntil(() => Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter, 30))
                {
                    Console.CursorLeft = 0;
                    Console.WriteLine(text);
                    break;
                }
            }
        }
    }
}