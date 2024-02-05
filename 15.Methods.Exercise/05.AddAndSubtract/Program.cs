
namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))); 
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Subtract(int num1, int num2, int num3)
        {
            return Add(num1, num2) - num3;
        }
    }
}
