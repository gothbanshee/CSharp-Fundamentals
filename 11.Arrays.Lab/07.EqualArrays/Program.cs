using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                sum += first[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
/*
10 20 30
10 20 30

1 2 3 4 5
1 2 4 3 5

1
10

*/