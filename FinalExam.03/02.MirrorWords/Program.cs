using System.Text;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(@|#)(?<FirstWord>[A-Za-z]{3,})(\1){2}(?<SecondWord>[A-Za-z]{3,})(\1)";

            List<string> words = new List<string>();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                StringBuilder second = new StringBuilder();
                for (int i = match.Groups["SecondWord"].Value.Length - 1; i >= 0; i--)
                {
                    second.Append(match.Groups["SecondWord"].Value[i]);
                }

                if (match.Groups["FirstWord"].Value == second.ToString())
                {
                    words.Add($"{match.Groups["FirstWord"].Value} <=> {match.Groups["SecondWord"].Value}");
                }
            }

            if (Regex.Matches(input, pattern).Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{Regex.Matches(input, pattern).Count} word pairs found!");

                if (words.Count == 0) Console.WriteLine("No mirror words!");

                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(String.Join(", ", words));
                }
            }
        }
    }
}
