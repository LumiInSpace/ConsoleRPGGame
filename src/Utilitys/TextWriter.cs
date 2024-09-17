namespace ConsoleRPGGame.src.Utilitys
{
<<<<<<<< HEAD:src/Utilitys/WriteText.cs
    public abstract class WriteText
========
    public abstract class TextWriter
>>>>>>>> c34975935ad89854cf28ff215ccaf8dd6e28daa0:src/Utilitys/TextWriter.cs
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
