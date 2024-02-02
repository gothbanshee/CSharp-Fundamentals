using System.Diagnostics;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] people = new int[int.Parse(Console.ReadLine())];
            int sum = 0;

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
