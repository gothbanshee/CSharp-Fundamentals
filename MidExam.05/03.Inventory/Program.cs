namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                            .Split(", ")
                            .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] command = input.Split(new char[] { '-', ':'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < command.Length; i++)
                {
                    command[i] = command[i].Trim();
                }

                switch (command[0])
                {
                    case "Collect":
                        if (!Exists(items, command))
                        {
                            items.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (Exists(items, command))
                        {
                            items.Remove(command[1]);
                        }
                        break;
                    case "Combine Items":
                        if (Exists(items, command))
                        {
                            items.Insert(items.FindIndex(x => x == command[1]) + 1, command[2]);
                        }
                        break;
                    case "Renew":
                        if (Exists(items, command))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", items));
        }

        static bool Exists(List<string> items, string[] command)
        {
            return items.Contains(command[1]);
        }
    }
}