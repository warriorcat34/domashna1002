namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banned words: ");
            string[] banWords = Console.ReadLine().Split(' ').ToArray(); 

            Console.WriteLine("Type a sentance: ");
            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                    new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
