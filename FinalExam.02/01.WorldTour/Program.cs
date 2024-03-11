namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] command = input.Split(':');

                switch (command[0])
                {
                    case "Add Stop":
                        if (IsValidIndex(int.Parse(command[1]), text))
                            text = text.Insert(int.Parse(command[1]), command[2]);
                        break;
                    case "Remove Stop":
                        if (IsValidIndex(int.Parse(command[1]), text) && IsValidIndex(int.Parse(command[2]), text))
                            text = text.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);
                        break;
                    case "Switch":
                        text = text.Replace(command[1], command[2]);
                        break;
                }

                Console.WriteLine(text);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }

        private static bool IsValidIndex(int index, string text)
        {
            return index >= 0 && index < text.Length;
        }
    }
}
