using System.Data;

namespace _03.HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public override string ToString()
        {
            return $"{Name}\r\n  HP: {Health}\r\n  MP: {Mana}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                                       .Split()
                                       .ToArray();

                heroes.Add(new Hero(info[0], int.Parse(info[1]), int.Parse(info[2])));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" - ");

                switch (command[0])
                {
                    case "CastSpell":
                        if (heroes.First(h => h.Name == command[1]).Mana >= int.Parse(command[2]))
                        {
                            heroes.First(h => h.Name == command[1]).Mana -= int.Parse(command[2]);
                            Console.WriteLine($"{command[1]} has successfully cast {command[3]} and now has {heroes.First(h => h.Name == command[1]).Mana} MP!");
                        }
                        else Console.WriteLine($"{command[1]} does not have enough MP to cast {command[3]}!");
                        break;
                    case "TakeDamage":
                        heroes.First(h => h.Name == command[1]).Health -= int.Parse(command[2]);

                        if (heroes.First(h => h.Name == command[1]).Health > 0) Console.WriteLine($"{command[1]} was hit for {command[2]} HP by {command[3]} and now has {heroes.First(h => h.Name == command[1]).Health} HP left!");

                        else
                        {
                            heroes.RemoveAt(heroes.FindIndex(h => h.Name == command[1]));
                            Console.WriteLine($"{command[1]} has been killed by {command[3]}!");
                        }
                        break;
                    case "Recharge":
                        Console.WriteLine($"{command[1]} recharged for {Math.Min((200 - heroes.First(h => h.Name == command[1]).Mana), int.Parse(command[2]))} MP!");

                        heroes.First(h => h.Name == command[1]).Mana = Math.Min((int.Parse(command[2]) + heroes.First(h => h.Name == command[1]).Mana), 200);
                        break;
                    case "Heal":
                        Console.WriteLine($"{command[1]} healed for {Math.Min((100 - heroes.First(h => h.Name == command[1]).Health), int.Parse(command[2]))} HP!");

                        heroes.First(h => h.Name == command[1]).Health = Math.Min((int.Parse(command[2]) + heroes.First(h => h.Name == command[1]).Health), 100);
                        break;
                }
            }

            heroes.ForEach(Console.WriteLine);
        }
    }
}
