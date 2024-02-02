namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            Triangle(end);

            static void PrintLine(int end)
            {
                for (int i = 1; i <= end; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            static void Triangle(int end)
            {
                for (int i = 1; i <= end; i++)
                {
                    PrintLine(i);
                }
                for (int i = end - 1; i > 0; i--)
                {
                    PrintLine(i);
                }
            }
        }
    }
}
