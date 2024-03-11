namespace _03.PlantDiscovery
{
    class Plant
    {
        public Plant(string name, int rarity, List<int> rating)
        {
            Name = name;
            Rarity = rarity;
            Rating = rating;
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }

        public override string ToString()
        {
            return $"- {Name}; Rarity: {Rarity}; Rating: {Rating.DefaultIfEmpty().Average():f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split("<->");

                if (!plants.Exists(p => p.Name == command[0])) plants.Add(new Plant(command[0], 0, new List<int>()));
                plants[plants.FindIndex(p => p.Name == command[0])].Rarity = int.Parse(command[1]);
            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                if (input.Contains("Rate"))
                {
                    input = input.Substring(6);
                    string[] command = input.Split(" - ").ToArray();

                    if (InvalidPlant(plants, command[0]))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    plants[plants.FindIndex(p => p.Name == command[0])].Rating.Add(int.Parse(command[1]));
                }
                else if (input.Contains("Update"))
                {
                    input = input.Substring(8);
                    string[] command = input.Split(" - ").ToArray();

                    if (InvalidPlant(plants, command[0]))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    plants[plants.FindIndex(p => p.Name == command[0])].Rarity = int.Parse(command[1]);
                }
                else
                {
                    input = input.Substring(7);

                    if (InvalidPlant(plants, input))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    plants[plants.FindIndex(p => p.Name == input)].Rating.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            plants.ForEach(Console.WriteLine);
        }

        private static bool InvalidPlant(List<Plant> plants, string command)
        {
            return !plants.Exists(p => p.Name == command);
        }
    }
}
