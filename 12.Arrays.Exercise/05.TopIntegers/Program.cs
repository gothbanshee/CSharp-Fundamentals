using System.Numerics;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool greater = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] <= numbers[j])
                    {
                        greater = false;
                        break;
                    }
                }
                if (greater == true)
                {
                    Console.Write(numbers[i] + " ");
                }
            }            
        }        
    }
}
