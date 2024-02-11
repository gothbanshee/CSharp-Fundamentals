using System.Text;

namespace _03.TakeOrSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            var result = new StringBuilder(numbers.Count);

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsNumber(input[i]))
                {
                    numbers.Add(input[i] - 48);
                    input = input.Remove(i, 1);
                    i--;
                }
            } // separating the numbers

            int lastIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (lastIndex >= input.Length)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    for (int j = 0; j < numbers[i]; j++)
                    {
                        result.Append(input[lastIndex]);
                        lastIndex++;

                        if (lastIndex >= input.Length)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    lastIndex += numbers[i];
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}