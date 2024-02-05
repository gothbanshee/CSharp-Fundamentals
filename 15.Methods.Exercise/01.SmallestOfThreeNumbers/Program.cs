

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMin(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

        }

        private static int GetMin(int num1, int num2, int num3)
        {
            int smallest = int.MinValue;
            if (Math.Min(num1, num2) < num3)
            {
                smallest = Math.Min(num1, num2);
            }
            else
            {
                smallest = num3;
            }
            return smallest;
        }
    }
}
