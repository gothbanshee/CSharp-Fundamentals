namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else
                {
                    string[] command = input.Split();
                    string change = command[0];
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);

                    if (change == "swap")
                    {
                        int newNum = numbers[firstIndex];
                        numbers[firstIndex] = numbers[secondIndex];
                        numbers[secondIndex] = newNum;
                    }
                    else if (change == "multiply")
                    {
                        numbers[firstIndex] *= numbers[secondIndex];
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}