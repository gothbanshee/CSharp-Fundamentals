namespace _04.Snowwhite
{
    class Dwarf
    {
        public Dwarf(string name, string hatColour, int physics)
        {
            Name = name;
            HatColour = hatColour;
            Physics = physics;
        }

        public string Name { get; set; }
        public string HatColour { get; set; }
        public int Physics { get; set; }

        public override string ToString()
        {
            return $"({HatColour}) {Name} <-> {Physics}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarves = new List<Dwarf>();

            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] command = input.Split(" <:> ");

                Dwarf dwarf = new Dwarf(command[0], command[1], int.Parse(command[2]));

                if (!dwarves.Exists(d => d.Name == command[0]))
                {
                    dwarves.Add(dwarf);
                }
                else if (dwarves[dwarves.FindIndex(d => d.Name == command[0])].HatColour != command[1])
                {
                    dwarves.Add(dwarf);
                }
                else
                {
                    dwarves[dwarves.FindIndex(d => d.Name == command[0])].Physics = Math.Max(int.Parse(command[2]), dwarves[dwarves.FindIndex(d => d.Name == command[0])].Physics);
                }
            }

            dwarves = dwarves.OrderByDescending(d => d.Physics)
                             .ThenByDescending(d => dwarves.Count(x => x.HatColour == d.HatColour))
                             .ToList();
            dwarves.ForEach(Console.WriteLine);
        }
    }
}