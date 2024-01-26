namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] longestDNA = new int[n];

            string input = Console.ReadLine();

            int index = 0;
            int longestIndexStart = int.MaxValue;
            int longestSum = 0;
            int longestCount = 0;
            int longestIndex = 1;


            while (input != "Clone them!")
            {
                int[] currentDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int count = 0;
                int sum = 0;
                index++;
                
                for (int i = n - 1; i >= 0; i--)
                {
                    if (currentDNA[i] == 1)
                    {
                        count++;
                        sum++;

                        if (longestCount < count || longestSum < sum || longestIndexStart > i)
                        {
                            longestDNA = currentDNA;
                            longestIndexStart = i;
                            longestSum = sum;
                            longestCount = count;
                            longestIndex = index;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {longestIndex} with sum: {longestSum}.");
            Console.WriteLine(String.Join(" ", longestDNA));
        }
    }
}
/*
5
1!0!1!1!0
0!1!1!0!0
Clone them!	

Best DNA sample 2 with sum: 2. 0 1 1 0 0

4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!	

Best DNA sample 1 with sum: 3. 1 1 0 1
*/