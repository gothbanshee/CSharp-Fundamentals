using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = n; i > 1; i--)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
