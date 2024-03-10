namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                if (!synonyms.ContainsKey(key))
                {
                    synonyms.Add(key, new List<string>());
                }

                synonyms[key].Add(Console.ReadLine());
            }

            foreach (var keyValuePair in synonyms)
            {
                Console.WriteLine($"{keyValuePair.Key} - {String.Join(", ", keyValuePair.Value)}");
            }
        }
    }
}
