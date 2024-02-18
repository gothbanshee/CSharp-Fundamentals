using System.Xml.Linq;

namespace _02.FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsMVT = Console.ReadLine()
                                             .Split(", ")
                                             .ToList();

            int blacklistedCountMVT = 0;
            int lostCountMVT = 0;

            string input;
            while ((input = Console.ReadLine()) != "Report")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Blacklist":
                        if (!friendsMVT.Contains(command[1]))
                        {
                            Console.WriteLine($"{command[1]} was not found.");
                            continue;
                        }
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        friendsMVT[friendsMVT.FindIndex(x => x == command[1])] = "Blacklisted";
                        blacklistedCountMVT++;
                        break;
                    case "Error":
                        if (IndexOutOfArray(friendsMVT, command))
                        {
                            continue;
                        }
                        else if (friendsMVT[int.Parse(command[1])] == "Blacklisted" || friendsMVT[int.Parse(command[1])] == "Lost")
                        {
                            continue;
                        }
                        Console.WriteLine($"{friendsMVT[int.Parse(command[1])]} was lost due to an error.");
                        friendsMVT[int.Parse(command[1])] = "Lost";
                        lostCountMVT++;
                        break;
                    case "Change":
                        if (IndexOutOfArray(friendsMVT, command))
                        {
                            continue;
                        }
                        Console.WriteLine($"{friendsMVT[int.Parse(command[1])]} changed his username to {command[2]}.");
                        friendsMVT[int.Parse(command[1])] = command[2];
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCountMVT}");
            Console.WriteLine($"Lost names: {lostCountMVT}");
            Console.WriteLine(String.Join(" ", friendsMVT));
        }

        static bool IndexOutOfArray(List<string> friendsMVT, string[] command)
        {
            return int.Parse(command[1]) < 0 || int.Parse(command[1]) >= friendsMVT.Count;
        }
    }
}