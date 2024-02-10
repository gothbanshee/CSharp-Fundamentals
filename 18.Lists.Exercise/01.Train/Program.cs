using System.Data;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (int.Parse(command[0]) + train[i] <= maxCapacity)
                        {
                            train[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", train));
        }
    }
}
