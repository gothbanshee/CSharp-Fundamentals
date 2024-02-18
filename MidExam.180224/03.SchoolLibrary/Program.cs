namespace _03.SchoolLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> booksMVT = Console.ReadLine()
                                           .Split("&")
                                           .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split(" | ");

                switch (command[0])
                {
                    case "Add Book":
                        if (!booksMVT.Contains(command[1]))
                        {
                            booksMVT.Reverse();
                            booksMVT.Add(command[1]);
                            booksMVT.Reverse();
                        }
                        break;
                    case "Take Book":
                        if (booksMVT.Contains(command[1]))
                        {
                            booksMVT.Remove(command[1]);
                        }
                        break;
                    case "Swap Books":
                        if (booksMVT.Contains(command[1]) && booksMVT.Contains(command[2]))
                        {
                            int firstIndex = booksMVT.FindIndex(x => x == command[1]);
                            int secondIndex = booksMVT.FindIndex(x => x == command[2]);
                            booksMVT[firstIndex] = command[2];
                            booksMVT[secondIndex] = command[1];
                        }
                        break;
                    case "Insert Book":
                        if (!booksMVT.Contains(command[1]))
                        {
                            booksMVT.Add(command[1]);
                        }
                        break;
                    case "Check Book":
                        if (IndexOutOfArray(booksMVT, command))
                        {
                            continue;
                        }
                        Console.WriteLine(booksMVT[int.Parse(command[1])]);
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", booksMVT));
        }

        static bool IndexOutOfArray(List<string> booksMVT, string[] command)
        {
            return int.Parse(command[1]) < 0 || int.Parse(command[1]) >= booksMVT.Count;
        }
    }
}