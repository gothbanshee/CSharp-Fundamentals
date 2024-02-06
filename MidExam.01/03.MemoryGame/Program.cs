using System.Xml.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                                           .Split()
                                           .ToList();

            string input;
            int moves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input.Split()
                                     .Select(int.Parse)
                                     .ToArray();

                moves++;

                if (indexes[0] == indexes[1] || IndexOutOfArray(elements, indexes))
                {
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[indexes[0]] == elements[indexes[1]])
                {
                    string deleted = elements[indexes[0]];
                    Console.WriteLine($"Congrats! You have found matching elements - {deleted}!");
                    elements.RemoveAll(x => x == deleted);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }
        }

        static bool IndexOutOfArray(List<string> elements, int[] indexes)
        {
            if (indexes[0] < 0 || indexes[1] < 0 || indexes[0] >= elements.Count || indexes[1] >= elements.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}