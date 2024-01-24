namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notRounded = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] rounded = new int[notRounded.Length];

            for (int i = 0; i < notRounded.Length; i++)
            {
                rounded[i] = (int)Math.Round(notRounded[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{notRounded[i]} => {rounded[i]}");
            }
        }
    }
}
/*0.9 1.5 2.4 2.5 3.14

-5.01 -1.599 -2.5 -1.50 0

*/