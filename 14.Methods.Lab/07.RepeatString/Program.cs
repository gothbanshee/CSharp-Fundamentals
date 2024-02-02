
namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintString(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        private static void PrintString(string input, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{input}");
            }
        }
    }
}
