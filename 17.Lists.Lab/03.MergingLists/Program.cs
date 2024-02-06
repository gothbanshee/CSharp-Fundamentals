using System.Collections.Generic;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count < secondList.Count)
            {
                result.AddRange(GetRemaining(firstList, secondList));
            }
            else if(firstList.Count > secondList.Count)
            {
                result.AddRange(GetRemaining(secondList, firstList));
            }

            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> GetRemaining(List<int> shorterList, List<int> longerList)
        {
            List<int> remaining = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                remaining.Add(longerList[i]);
            }

            return remaining;
        }
    }
}
