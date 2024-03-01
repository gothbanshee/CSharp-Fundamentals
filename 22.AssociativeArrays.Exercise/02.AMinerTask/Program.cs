namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resources = new Dictionary<string, uint>();

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                AddKeyIfMissing(resources, input);

                resources[input] += uint.Parse(Console.ReadLine());
            }

            foreach (var keyValuePair in resources)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }

        private static void AddKeyIfMissing(Dictionary<string, uint> resources, string input)
        {
            if (!resources.ContainsKey(input))
            {
                resources.Add(input, 0);
            }
        }
    }
}