namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            static void GetArea(int width, int height)
            {
                Console.WriteLine(width * height);
            }
        }
    }
}
