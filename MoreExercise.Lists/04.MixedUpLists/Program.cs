namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstRow = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            List<int> secondRow = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();
            secondRow.Reverse();

            List<int> range = new List<int>();
            GetRange(firstRow, secondRow, range);

            List<int> result = new List<int>();
            FillResult(firstRow, secondRow, result);

            result.RemoveAll(x => x <= range[0] || x >= range[1]);

            Console.WriteLine(String.Join(" ", result));
        }

        static void FillResult(List<int> firstRow, List<int> secondRow, List<int> result)
        {
            for (int i = 0; i < Math.Min(firstRow.Count, secondRow.Count); i++)
            {
                result.Add(firstRow[i]);
                result.Add(secondRow[i]);
            }
            result.Sort();
        }

        static void GetRange(List<int> firstRow, List<int> secondRow, List<int> range)
        {
            if (firstRow.Count > secondRow.Count)
            {
                range.Add(firstRow[firstRow.Count - 1]);
                range.Add(firstRow[firstRow.Count - 2]);
            }
            else
            {
                range.Add(secondRow[secondRow.Count - 1]);
                range.Add(secondRow[secondRow.Count - 2]);
            }
            range.Sort();
        }
    }
}
