using System.Text;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder sb = new StringBuilder();
                sb.Capacity = input.Length;
                int counter = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (counter > key.Length - 1) counter = 0;
                    sb.Append((char)(input[i] - key[counter]));
                    counter++;
                }

                string text = sb.ToString();
                string type = text.Substring(text.IndexOf('&') + 1, text.LastIndexOf('&') - text.IndexOf('&') - 1);
                string coordinates = text.Substring(text.IndexOf('<') + 1, text.IndexOf('>') - text.IndexOf('<') - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
