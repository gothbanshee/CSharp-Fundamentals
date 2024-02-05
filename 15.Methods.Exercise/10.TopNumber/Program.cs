

using System.Data.Common;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 17; i <= num; i++)
            {
                if (DivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool HasOddDigit(int i)
        {
            while (i > 0)
            {
                if (i % 2 !=0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool DivisibleBy8(int num)
        {
            int digitSum = 0;

            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
