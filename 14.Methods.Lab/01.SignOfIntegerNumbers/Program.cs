namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberSign(int.Parse(Console.ReadLine()));

            static void NumberSign(int num)
            {
                if (num == 0)
                {
                    Console.WriteLine($"The number {num} is zero.");
                }
                else if (num > 0)
                {
                    Console.WriteLine($"The number {num} is positive.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is negative.");
                }
            }
        }
    }
}
