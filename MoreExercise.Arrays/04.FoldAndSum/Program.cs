namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialRow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if(initialRow.Length == 1 )
            {
                Console.WriteLine(initialRow[0]);
            }

            int nums = initialRow.Length / 4;

            int[] firstRow = new int[nums * 2];

            for (int i = 0; i < firstRow.Length; i++)
            {
                int j = nums - 1 - i;

                if (j < 0)
                {
                    j = initialRow.Length - Math.Abs(j);
                    firstRow[i] = initialRow[j];
                }

                firstRow[i] = initialRow[j];
            }

            int[] secondRow = new int[nums * 2];

            for (int i = 0; i < secondRow.Length; i++)
            {
                int j = nums + i;
                secondRow[i] = initialRow[j];
            }

            for (int i = 0;i < firstRow.Length; i++)
            {
                Console.Write($"{firstRow[i] + secondRow[i]} ");
            }
        }
    }
}
