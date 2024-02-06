using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] firstRow = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] secondRow = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            if(firstRow.Length < secondRow.Length)
            {
                Console.WriteLine(String.Join("", firstRow));
                Console.WriteLine(String.Join("", secondRow));
                return;
            }
            else if (secondRow.Length < firstRow.Length)
            {
                Console.WriteLine(String.Join("", secondRow));
                Console.WriteLine(String.Join("", firstRow));
                return;
            }

            for (int i = 0; i < firstRow.Length; i++)
            {
                if (firstRow[i] < secondRow[i])
                {
                    Console.WriteLine(String.Join("", firstRow));
                    Console.WriteLine(String.Join("", secondRow));
                    return;
                }
                else if (firstRow[i] > secondRow[i])
                {
                    Console.WriteLine(String.Join("", secondRow));
                    Console.WriteLine(String.Join("", firstRow));
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(String.Join("", firstRow));
            Console.WriteLine(String.Join("", secondRow));
        }
    }
}