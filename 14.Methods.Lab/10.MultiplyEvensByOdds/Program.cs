

using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultiplySum(input));
        }

        private static int GetMultiplySum(int input)
        {
            int result = GetEvenSum(input) * GetOddSum(input);
            return result;
        }

        static int GetOddSum(int input)
        {
            int oddSum = 0;
            while (input > 0)
            {
                if ((input % 10) % 2 != 0)
                {
                    oddSum += input % 10;
                }
                input /= 10;
            }
            return oddSum;
        }

        private static int GetEvenSum(int input)
        {
            int evenSum = 0;
            while (input > 0)
            {
                if ((input % 10) % 2 == 0)
                {
                    evenSum += input % 10;
                }
                input /= 10;
            }
            return evenSum;
        }
    }
}
