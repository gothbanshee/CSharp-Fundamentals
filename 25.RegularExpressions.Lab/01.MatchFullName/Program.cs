using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<FullName>\b(?<FirstName>[A-Z][a-z]+) (?<LastName>)[A-Z][a-z]+\b)";
            string input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.Write(match.Value + ' ');
            }
        }
    }
}
