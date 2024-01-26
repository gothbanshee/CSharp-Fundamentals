
namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            int row = 0;

            for (int i = 0; i < n; i++)
            {
                int[] holder = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                row++;

                if (row % 2 != 0)
                {
                    first[i] = holder[0];
                    second[i] = holder[1];
                }
                else
                {
                    first[i] = holder[1];
                    second[i] = holder[0];
                }
            }
            Console.WriteLine(String.Join(" ", first));
            Console.WriteLine(String.Join(" ", second));
        }
    }
}
/*
4
1 5
9 10
31 81
41 20

1 10 31 20
5 9 81 41

2
80 23
31 19

80 19
23 31

*/
