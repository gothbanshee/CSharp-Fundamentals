using System.Text.RegularExpressions;

namespace _1.WinningTicket // only 70/100 in Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string validPattern = @"(?<FirstHalf>[^@#$^]{0,4}(?<Repetition>(?<Sign>[@#$^]){6,10})[^@#$^]{0,4})(?<SecondHalf>[^@#$^]{0,4}(\2)[^@#$^]{0,4})";
            string invalidPattern = @"(?<FirstHalf>[^@#$^]{0,5}[@#$^]{0,5}[^@#$^]{0,5})(?<SecondHalf>[^@#$^]{0,5}[@#$^]{0,5}[^@#$^]{0,5})";

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.TrimEntries)
                .ToArray();

            foreach (string ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    if (Regex.Match(ticket, validPattern).Success)
                    {
                        if (Regex.Match(ticket, validPattern).Groups["Repetition"].Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {Regex.Match(ticket, validPattern).Groups["Repetition"].Length}{Regex.Match(ticket, validPattern).Groups["Sign"].Value}");
                        }
                        else if (Regex.Match(ticket, validPattern).Groups["Repetition"].Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {Regex.Match(ticket, validPattern).Groups["Repetition"].Length}{Regex.Match(ticket, validPattern).Groups["Sign"].Value} Jackpot!");
                        }
                    }
                    else if (Regex.Match(ticket, invalidPattern).Success) Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
