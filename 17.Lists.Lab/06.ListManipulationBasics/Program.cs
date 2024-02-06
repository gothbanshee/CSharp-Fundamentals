namespace _06.ListManipulationBasics
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

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
/*
4 19 2 53 6 43
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end

*/