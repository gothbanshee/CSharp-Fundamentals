
namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintChars(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }

        private static void PrintChars(char start, char end)
        {
            if (start > end)
            {
                char forSaving = start;
                start = end;
                end = forSaving;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
        }
    }
}
