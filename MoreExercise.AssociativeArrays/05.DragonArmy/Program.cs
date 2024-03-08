using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace _05.DragonArmy
{
    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public override string ToString()
        {
            return $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> colors = new Dictionary<string, List<Dragon>>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split()
                                          .ToArray();

                string color = command[0];
                string name = command[1];
                if (int.TryParse(command[2], out int damage)) { }
                else
                {
                    damage = 45;
                }

                if (int.TryParse(command[3], out int health)) { }
                else
                {
                    health = 250;
                }

                if (int.TryParse(command[4], out int armor)) { }
                else
                {
                    armor = 10;
                }

                Dragon dragon = new Dragon(name, damage, health, armor);

                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new List<Dragon>());
                }

                if (!colors[color].Exists(d => d.Name == name))
                {
                    colors[color].Add(dragon);
                }
                else
                {
                    colors[color].First(d => d.Name == name).Damage = damage;
                    colors[color].First(d => d.Name == name).Health = health;
                    colors[color].First(d => d.Name == name).Armor = armor;
                }

                colors[color] = colors[color].OrderBy(d => d.Name).ToList();
            }

            foreach (var keyValuePair in colors)
            {
                double avDmg = keyValuePair.Value.Select(d => d.Damage).Average();
                double avHP = keyValuePair.Value.Select(d => d.Health).Average();
                double avArmor = keyValuePair.Value.Select(d => d.Armor).Average();
                Console.WriteLine($"{keyValuePair.Key}::({avDmg:f2}/{avHP:f2}/{avArmor:f2})");

                keyValuePair.Value.OrderBy(d => d.Name).ToList();
                keyValuePair.Value.ForEach(Console.WriteLine);
            }
        }
    }
}
