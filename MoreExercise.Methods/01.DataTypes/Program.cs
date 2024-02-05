using System.Numerics;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    Console.WriteLine(Integer(int.Parse(Console.ReadLine())));
                    break;
                case "real":
                    Console.WriteLine($"{(Double(double.Parse(Console.ReadLine()))):f2}");
                    break;
                case "string":
                    String(Console.ReadLine());
                    break;
            }
        }

        static void String(string? text)
        {
            Console.WriteLine($"${text}$");
        }

        static double Double(double num)
        {
            return num * 1.5;
        }

        static int Integer(int num)
        {
            return num * 2;
        }
    }
}
