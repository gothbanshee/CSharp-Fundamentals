
namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloserPoint(x1, y1, x2, y2);
        }

        static double FirstDistance(double x1, double y1)
        {
            return (Math.Abs(x1) + Math.Abs(y1));
        }

        static double SecondDistance(double x2, double y2)
        {
            return (Math.Abs(x2) + Math.Abs(y2));
        }

        static void PrintCloserPoint(double x1, double y1, double x2, double y2)
        {
            if (FirstDistance(x1, y1) <= SecondDistance(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}