using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    enum AttackType
    {
        Unknown,
        Attack,
        Destroy
    }

    class Message
    {
        public Message(string planet, uint population, string type, uint soldiers)
        {
            Planet = planet;
            Population = population;
            Type = type == "A" ? AttackType.Attack : AttackType.Destroy;
            Soldiers = soldiers;
        }

        public string Planet { get; }
        public uint Population { get; }
        public AttackType Type { get; }
        public uint Soldiers { get; }

        public override string ToString()
        {
            return $"-> {Planet}";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Message> messages = new List<Message>();

            for (int i = 0; i < count; i++)
            {
                string starPattern = @"[starSTAR]";
                string input = Console.ReadLine();

                StringBuilder sb = new StringBuilder();
                foreach (char c in input)
                {
                    sb.Append((char)(c - Regex.Matches(input, starPattern).Count));
                }

                string toDecrypt = sb.ToString();

                string decryptPattern = @"@(?<Planet>[A-Za-z]+)[^@\-!:>]*:(?<Population>\d+)[^@\-!:>]*!(?<Type>[AD])![^@\-!:>]*->(?<Soldiers>\d+)";

                foreach (Match match in Regex.Matches(toDecrypt, decryptPattern))
                {

                    messages.Add(new Message(match.Groups["Planet"].Value, uint.Parse(match.Groups["Population"].Value), match.Groups["Type"].Value, uint.Parse(match.Groups["Soldiers"].Value)));
                }
            }

            messages = messages.OrderBy(m => m.Planet)
                               .ToList();

            Console.WriteLine($"Attacked planets: {messages.Where(m => m.Type == AttackType.Attack).Count()}");
            foreach (var message in messages.Where(m => m.Type == AttackType.Attack))
            {
                Console.WriteLine(message);
            }

            Console.WriteLine($"Destroyed planets: {messages.Where(m => m.Type == AttackType.Destroy).Count()}");
            foreach (var message in messages.Where(m => m.Type == AttackType.Destroy))
            {
                Console.WriteLine(message);
            }
        }
    }
}
