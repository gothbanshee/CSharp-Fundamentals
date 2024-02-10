namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string[] guest = Console.ReadLine()
                                        .Split()
                                        .ToArray();

                if (guest.Length == 3)
                {
                    if (guests.Contains(guest[0]))
                    {
                        Console.WriteLine($"{guest[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(guest[0]);
                    }
                }
                else
                {
                    if (!guests.Contains(guest[0]))
                    {
                        Console.WriteLine($"{guest[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(guest[0]);
                    }
                }
            }
            Console.WriteLine(String.Join("\n", guests));
        }
    }
}
