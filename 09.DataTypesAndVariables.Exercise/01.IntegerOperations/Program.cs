namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            short num4 = short.Parse(Console.ReadLine());

            Console.WriteLine($"{(num1 + num2) / num3 * num4}");
        }
    }
}
