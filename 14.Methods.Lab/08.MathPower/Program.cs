
using System.Numerics;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowOfNum(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        private static void PowOfNum(double num, int power)
        {
            Console.WriteLine(Math.Pow(num, power));
        }
    }
}
