namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToArray();

            int[] warship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToArray();

            int maxHealth = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split();

                if (command[0] == "Fire")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= warship.Length)
                    {
                        continue;
                    }
                    warship[int.Parse(command[1])] -= int.Parse(command[2]);

                    if (warship[int.Parse(command[1])] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
                else if (command[0] == "Defend")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= pirateShip.Length || int.Parse(command[2]) < 0 || int.Parse(command[2]) >= pirateShip.Length)
                    {
                        continue;
                    }

                    for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                    {
                        pirateShip[i] -= int.Parse(command[3]);
                        if (pirateShip[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= pirateShip.Length)
                    {
                        continue;
                    }
                    pirateShip[int.Parse(command[1])] += int.Parse(command[2]);

                    if (pirateShip[int.Parse(command[1])] > maxHealth)
                    {
                        pirateShip[int.Parse(command[1])] = maxHealth;
                    }
                }
                else if(command[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        if (pirateShip[i] < maxHealth * 0.20)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}