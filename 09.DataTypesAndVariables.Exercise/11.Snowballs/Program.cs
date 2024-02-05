using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());
            int printSnow = 0;
            int printTime = 0;
            int printQuality = 0;
            BigInteger printValue = 0;

            for (int i = 0; i < balls; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, quality);

                if (printValue < value)
                {
                    printValue = value;
                    printSnow = snow;
                    printTime = time;
                    printQuality = quality;
                }
            }

            Console.WriteLine($"{printSnow} : {printTime} = {printValue} ({printQuality})");
        }
    }
}
