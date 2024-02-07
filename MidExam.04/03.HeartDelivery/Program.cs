namespace _03.HeartDelivery

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                                  .Split('@')
                                  .Select(int.Parse)
                                  .ToArray();

            string input;
            int i = 0;
            int failedHouses = houses.Length;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] move = input.Split();

                i += int.Parse(move[1]);

                if (i >= houses.Length)
                {
                    i = 0;
                }
                if (houses[i] == 0)
                {
                    Console.WriteLine($"Place {i} already had Valentine's day.");
                    continue;
                }
                houses[i] -= 2;
                if (houses[i] == 0)
                {
                    Console.WriteLine($"Place {i} has Valentine's day.");
                    failedHouses--;
                }
            }
            Console.WriteLine($"Cupid's last position was {i}.");
            if (failedHouses > 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}