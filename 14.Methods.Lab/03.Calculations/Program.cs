namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "add")
            {
                AddNums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (command == "subtract")
            {
                SubtractNums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (command == "multiply")
            {
                MultiplyNums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else
            {
                DivideNums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }

            static void AddNums(int num1, int num2)
            {
                Console.WriteLine(num1 + num2);
            }

            static void SubtractNums(int num1, int num2)
            {
                Console.WriteLine(num1 - num2);
            }

            static void MultiplyNums(int num1, int num2)
            {
                Console.WriteLine(num1 * num2);
            }

            static void DivideNums(int num1, int num2)
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}
