using System;

namespace _01.LargestCommonEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine()
                                       .Split();

            string[] secondRow = Console.ReadLine()
                                       .Split();

            int frontMatches = MatchesFound(firstRow, secondRow);
            Array.Reverse(firstRow);
            Array.Reverse(secondRow);
            int endMatches = MatchesFound(firstRow, secondRow);

            if (frontMatches >= endMatches)
            {
                Console.WriteLine(frontMatches);
            }
            else
            {
                Console.WriteLine(endMatches);
            }
        }

        static int MatchesFound(string[] firstRow, string[] secondRow)
        {
            int matches = 0;
            for (int i = 0; i < Math.Min(firstRow.Length, secondRow.Length); i++)
            {
                if (firstRow[i] == secondRow[i])
                {
                    matches++;
                }
                else
                {
                    break;
                }
            }
            return matches;
        }
    }
}
