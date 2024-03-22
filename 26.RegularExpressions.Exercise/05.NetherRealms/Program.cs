using System.Text.RegularExpressions;

namespace _05.NetherRealms // only 90/100 in Judge
{
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:F2} damage";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();
            string splitPattern = @"[,\s]+";

            string[] input = Regex.Split(Console.ReadLine(), splitPattern).OrderBy(d => d).ToArray();

            foreach (string line in input)
            {
                string healthPattern = @"[^\d.+\-/*]";
                string damagePattern = @"((-|)[\d|\d\.\d]+)";
                int health = 0;
                double damage = 0;

                foreach (Match match in Regex.Matches(line, healthPattern))
                {
                    health += char.Parse(match.Value);
                }

                foreach (Match match in Regex.Matches(line, damagePattern))
                {
                    damage += double.Parse(match.Value);
                }

                foreach (char c in line)
                {
                    if (c == '*') damage *= 2;
                    else if (c == '/') damage /= 2;
                }

                demons.Add(new Demon(line, health, damage));
            }

            demons.ForEach(Console.WriteLine);
        }
    }
}
