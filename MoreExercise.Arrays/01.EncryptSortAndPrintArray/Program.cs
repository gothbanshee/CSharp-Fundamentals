using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                return;
            }

            string[] names = new string[n];
            int[] values = new int[n];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                for (int j = 0; j < names[i].Length; j++)
                {
                    if (names[i][j] == 'a' || names[i][j] == 'o' || names[i][j] == 'u' || names[i][j] == 'e' || names[i][j] == 'i')
                    {
                        sum += names[i][j] * names[i].Length;
                    }
                    else
                    {
                        sum += names[i][j] / names[i].Length;
                        if (names[i][j] / names[i].Length < 1)
                        {
                            sum++;
                        }
                    }
                    values[i] = sum;
                }
            }

            Array.Sort(values);
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
