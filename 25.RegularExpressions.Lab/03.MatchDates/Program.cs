using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<Whole>(?<Date>\d{2})(\.|-|/)(?<Month>[A-Z][a-z]{2})(\1)(?<Year>\d{4})\b)";
            string input = Console.ReadLine();
            
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"Day: {match.Groups["Date"].Value}, Month: {match.Groups["Month"].Value}, Year: {match.Groups["Year"].Value}");
            }
        }
    }
}
