namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                                          .Split(", ")
                                          .ToArray();

            string toChange = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                while (toChange.Contains(word)) toChange = toChange.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(toChange);
        }
    }
}
