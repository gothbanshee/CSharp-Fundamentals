namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 60)
            {
                return;
            }
            if (num == 1)
            {
                Console.WriteLine("1");
                return;
            }

            ulong[] prevRow = { 1, 1 };

            Console.WriteLine("1");
            Console.WriteLine("1 1");

            for (int i = 3; i <= num; i++)
            {
                ulong[] row = new ulong[i];
                row[0] = 1;
                row[row.Length - 1] = 1;

                for (int j = 1; j <= row.Length - 2; j++)
                {
                    if (j < 1)
                    {
                        continue;
                    }
                    row[j] = prevRow[j - 1] + prevRow[j];
                }

                Console.WriteLine(String.Join(" ", row));
                prevRow = row;
            }
        }
    }
}