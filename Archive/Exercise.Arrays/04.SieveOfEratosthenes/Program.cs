using System;

namespace _04.SieveOfEratosthenes // 80/100 in Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            switch (end)
            {
                case 0:
                case 1:
                    return;
                case 2:
                    Console.WriteLine("2");
                    return;
                case 3:
                    Console.WriteLine("2 3");
                    return;
                case 4:
                case 5: 
                case 6:
                    Console.WriteLine("2 3 5");
                    return;
                case 7:
                    Console.WriteLine("2 3 5 7");
                    return;
            }
            Console.Write("2 3 5 7 ");
            for (int i = 2; i <= end; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
