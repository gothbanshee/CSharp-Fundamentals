using System.Globalization;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();
            string pattern = @" (?<Address>(?<User>[A-Za-z]+[\.\-_]*?[A-Za-z]+)@(?<Host>[A-Za-z]+[-]*?[A-Za-z]+([\.]+[A-Za-z]+[-]*?[A-Za-z]+)+))";

            string input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                emails.Add(match.Groups["Address"].Value);
            }

            emails.ForEach(Console.WriteLine);
        }
    }
}
