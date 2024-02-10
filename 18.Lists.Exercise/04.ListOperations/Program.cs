namespace _04.ListOperations
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
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            Shift(numbers, command);
                        }
                        else
                        {
                            numbers.Reverse();
                            Shift(numbers, command);
                            numbers.Reverse();
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void Shift(List<int> numbers, string[] command)
        {
            for (int i = 0; i < int.Parse(command[2]) % numbers.Count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
    }
}