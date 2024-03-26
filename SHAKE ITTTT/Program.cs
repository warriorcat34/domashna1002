namespace SHAKE_ITTTT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input: ");
            string str = Console.ReadLine();

            Console.WriteLine("pattern: ");
            string pattern = Console.ReadLine();
            bool success = ShakeString(ref str, pattern);

            if (success)
            {
                Console.WriteLine("Shaked it.");
            }
            else
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(str);
            }
        }

        static bool ShakeString(ref string str, string pattern)
        {
            int patternLength = pattern.Length;
            bool success = false;

            while (true)
            {
                int firstIndex = str.IndexOf(pattern);
                int lastIndex = str.LastIndexOf(pattern);

                if (firstIndex != -1 && lastIndex != -1 && firstIndex != lastIndex)
                {
                    str = str.Remove(firstIndex, patternLength);
                    str = str.Remove(lastIndex - patternLength + 1, patternLength);
                    pattern = pattern.Remove(patternLength / 2, 1);
                    success = true;
                }
                else
                {
                    break;
                }
            }

            return success;
        }
    }
    
}
