namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string input;
            bool changed = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int number in numbers)
                        {
                            if (number % 2 == 0)
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int number in numbers)
                        {
                            if (number % 2 != 0)
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        switch (command[1])
                        {
                            case "<":
                                foreach (int number in numbers)
                                {
                                    if (number < int.Parse(command[2]))
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                foreach (int number in numbers)
                                {
                                    if (number > int.Parse(command[2]))
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (int number in numbers)
                                {
                                    if (number <= int.Parse(command[2]))
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (int number in numbers)
                                {
                                    if (number >= int.Parse(command[2]))
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }

            if(changed)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}