using System.Text;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string input = Console.ReadLine();
            var result = new StringBuilder(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                while (numbers[i] > 0)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                while (sum >= input.Length)
                {
                    sum -= input.Length;
                }

                result.Append(input[sum]);
                input = input.Remove(sum, 1);
            }

            Console.WriteLine(result.ToString());
        }
    }
}