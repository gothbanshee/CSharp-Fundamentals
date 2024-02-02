using System;
using System.Linq;

namespace _07.SumArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstRow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondRow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = new int[Math.Max(firstRow.Length, secondRow.Length)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i % firstRow.Length] + secondRow[i % secondRow.Length];
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
