namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static double FirstLine(double x1, double y1, double x2, double y2)
        {
            return (Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2));
        }

        static double SecondLine(double x3, double y3, double x4, double y4)
        {
            return (Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4));
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (FirstLine(x1, y1, x2, y2) >= SecondLine(x3, y3, x4, y4))
            {
                if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (Math.Abs(x3) + Math.Abs(y3) <= Math.Abs(x4) + Math.Abs(y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
