namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split()
                                    .ToArray();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurrences.ContainsKey(input[i].ToLower()))
                {
                    occurrences.Add(input[i].ToLower(), 0);
                }

                occurrences[input[i].ToLower()]++;
            }

            foreach (var keyValuePair in occurrences)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    Console.Write($"{keyValuePair.Key} ");
                }
            }
        }
    }
}
