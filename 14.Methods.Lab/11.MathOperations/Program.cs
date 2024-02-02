
namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine(Plus(firstNum, secondNum));
                    break;
                case '-':
                    Console.WriteLine(Minus(firstNum, secondNum));
                    break;
                case '*':
                    Console.WriteLine(Star(firstNum, secondNum));
                    break;
                case '/':
                    Console.WriteLine(Slash(firstNum, secondNum));
                    break;
            }
        }

        private static double Plus(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            return result;
        }
        private static double Minus(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            return result;
        }
        private static double Star(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }
        private static double Slash(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            return result;
        }
    }
}
