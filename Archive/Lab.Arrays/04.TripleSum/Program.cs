using System;
using System.Linq;

namespace _04.TripleSum // only 60/100 in Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool zeroes = true;
            foreach (int number in numbers)
            {
                if (number != 0)
                {
                    zeroes = false;
                }
            }

            if (zeroes)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("0 + 0 == 0");
                }
                return;
            }

            int count = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        if (numbers[a] + numbers[b] == numbers[c] && a < b)
                        {
                            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[c]}");
                            count++;
                        }
                    }
                }
            }

            if (count == 0 )
            {
                Console.WriteLine("No");
            }
        }
    }
}