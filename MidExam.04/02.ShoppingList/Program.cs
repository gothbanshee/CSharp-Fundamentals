using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                                       .Split("!")
                                       .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Urgent":
                        if (!ExistsInList(list, command))
                        {
                            list.Insert(0,command[1]);
                        }
                        break;
                    case "Unnecessary":
                        if (ExistsInList(list, command))
                        {
                            list.Remove(command[1]);
                        }
                        break;
                    case "Correct":
                        if (ExistsInList(list, command))
                        {
                            list[list.FindIndex(x => x == command[1])] = command[2];
                        }
                        break;
                    case "Rearrange":
                        if (ExistsInList(list, command))
                        {
                            list.Remove(command[1]);
                            list.Add(command[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", list));
        }

        static bool ExistsInList(List<string> list, string[] command)
        {
            return list.Exists(x => x == command[1]);
        }
    }
}