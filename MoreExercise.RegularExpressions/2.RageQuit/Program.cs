using System.Text;
using System.Text.RegularExpressions;

namespace _2.RageQuit // only 90/100 in Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<Text>[\D]+)(?<Times>[\d]+)";

            StringBuilder sb = new StringBuilder();

            string uniqueLetters = "";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                for (int i = 0; i < int.Parse(match.Groups["Times"].Value); i++)
                {
                    sb.Append(match.Groups["Text"].Value.ToUpper());

                }

                foreach (char c in match.Groups["Text"].Value)
                {
                    if (!uniqueLetters.Contains(char.ToLower(c))) uniqueLetters += char.ToLower(c);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueLetters.Length}");
            Console.WriteLine(sb.ToString());
        }
    }
}
