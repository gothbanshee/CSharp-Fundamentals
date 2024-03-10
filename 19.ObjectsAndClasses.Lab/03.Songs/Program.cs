namespace _03.Songs
{
    class Song
    {
        public Song(string list, string name, string length)
        {
            List = list;
            Name = name;
            Length = length;
        }

        public string List { get; }
        public string Name { get; }
        public string Length { get; }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split('_')
                                          .ToArray();

                songs.Add(new Song(command[0], command[1], command[2]));
            }

            string toPrint = Console.ReadLine();
            if (toPrint == "all")
            {
                Console.WriteLine(String.Join("\n", songs));
            }
            else
            {
                Console.WriteLine(String.Join("\n", songs.Where(s => s.List == toPrint)));
            }
        }
    }
}
