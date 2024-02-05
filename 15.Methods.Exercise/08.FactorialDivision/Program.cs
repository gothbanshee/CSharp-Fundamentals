namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Factorial(int.Parse(Console.ReadLine())) / Factorial(int.Parse(Console.ReadLine())):f2}");

            static double Factorial(int num)
            {
                double factorial = 1;
                if (num == 0)
                {
                    return factorial;
                }
                for (int i = num; i > 0; i--)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
