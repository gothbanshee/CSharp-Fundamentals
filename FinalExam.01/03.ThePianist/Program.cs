namespace _03.ThePianist
{
    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                        .Split('|')
                                        .ToArray();

                pieces.Add(new Piece(command[0], command[1], command[2]));
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split('|')
                                        .ToArray();

                switch (command[0])
                {
                    case "Add":
                        if (pieces.Exists(p => p.Name == command[1]))
                            Console.WriteLine($"{command[1]} is already in the collection!");
                        else
                        {
                            pieces.Add(new Piece(command[1], command[2], command[3]));
                            Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (!pieces.Exists(p => p.Name == command[1]))
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        else
                        {
                            pieces.Remove(pieces.First(p => p.Name == command[1]));
                            Console.WriteLine($"Successfully removed {command[1]}!");
                        }
                        break;
                    case "ChangeKey":
                        if (!pieces.Exists(p => p.Name == command[1]))
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        else
                        {
                            pieces.First(p => p.Name == command[1]).Key = command[2];
                            Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                        }
                        break;
                }
            }

            pieces.ForEach(Console.WriteLine);
        }
    }
}
