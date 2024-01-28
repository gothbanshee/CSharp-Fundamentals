using System.Threading;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|");

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] command = rooms[i].Split();

                if (command[0] == "potion")
                {
                    health += int.Parse(command[1]);
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - (health - int.Parse(command[1]))} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {command[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (command[0] == "chest")
                {
                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {command[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
