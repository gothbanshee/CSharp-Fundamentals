namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == ' ')
                {
                    continue;
                }

                AddKeyIfMissing(charOccurrences, currentChar);

                charOccurrences[currentChar]++;
            }

            foreach (KeyValuePair<char, int> keyValuePair in charOccurrences)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }

        private static void AddKeyIfMissing(Dictionary<char, int> charOccurrences, char currentChar)
        {
            if (!charOccurrences.ContainsKey(currentChar))
            {
                charOccurrences.Add(currentChar, 0);
            }
        }
    }
}