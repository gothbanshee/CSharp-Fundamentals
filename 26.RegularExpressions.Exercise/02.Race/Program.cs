using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Participant
    {
        public Participant(string name, uint distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get; set; }
        public uint Distance { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participants = new List<Participant>();
            List<string> participantsNames = Console.ReadLine()
                                                .Split(", ")
                                                .ToList();

            foreach (string name in participantsNames)
            {
                participants.Add(new Participant(name, 0));
            }

            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"\d";

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    sb.Append(match);
                }

                if (participants.Exists(p => p.Name == sb.ToString()))
                {
                    uint totalDistance = 0;
                    foreach (Match match in Regex.Matches(input, digitsPattern))
                    {
                        totalDistance += uint.Parse(match.Value);
                    }

                    participants.First(p => p.Name == sb.ToString()).Distance += totalDistance;
                }
            }

            participants = participants.OrderByDescending(p => p.Distance)
                                       .Take(3)
                                       .ToList();

            Console.WriteLine($"1st place: {participants[0]}");
            Console.WriteLine($"2nd place: {participants[1]}");
            Console.WriteLine($"3rd place: {participants[2]}");
        }
    }
}
