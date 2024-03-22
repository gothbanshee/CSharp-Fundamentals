using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> numbers = new List<string>(input.Length);

            string pattern = @"\+359([ |-])2(\1)\d{3}(\1)\d{4}\b";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                numbers.Add(match.Value);
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
