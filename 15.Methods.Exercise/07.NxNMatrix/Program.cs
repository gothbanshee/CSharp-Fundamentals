
namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NxNMatrix(int.Parse(Console.ReadLine()));
        }

        private static void NxNMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
