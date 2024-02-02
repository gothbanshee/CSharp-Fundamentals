using System;

namespace _03.LastKNumbersSums // only 80/100 in Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            if (length <= 0)
            {
                return;
            }

            int[] numbers = new int[length];

            int k = int.Parse(Console.ReadLine());
            if (k < 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }

            numbers[0] = 1;

            if (length == 1)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (k == 0)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        numbers[j] = 1;
                    }
                }
                else
                {
                    for (int j = k; j > 0; j--)
                    {
                        if (i - j < 0)
                        {
                            for (int m = i; m > 0; m--)
                            {
                                numbers[i] += numbers[i - m];
                            }
                            break;
                        }
                        numbers[i] += numbers[i - j];
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
