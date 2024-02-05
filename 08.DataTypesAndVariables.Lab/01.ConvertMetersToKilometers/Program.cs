namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(double.Parse(Console.ReadLine()) / 1000):f2}");
        }
    }
}
