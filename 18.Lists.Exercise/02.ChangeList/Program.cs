namespace _02.ChangeList
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
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(command[1]));
                }
                else
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
