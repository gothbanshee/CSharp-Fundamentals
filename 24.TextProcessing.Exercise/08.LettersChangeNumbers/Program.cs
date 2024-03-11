namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            double sum = 0;

            foreach (string input in line)
            {
                double number = double.Parse(input.Substring(1, input.Length - 2));

                if (char.IsUpper(input[0])) number /= input[0] - 64;

                else if (char.IsLower(input[0])) number *= input[0] - 96;

                if (char.IsUpper(input[^1])) number -= input[^1] - 64;

                else if (char.IsLower(input[^1])) number += input[^1] - 96;

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
