namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            if (first.Length < 2)
            {
                Console.WriteLine(first[0]);
                return;
            }

            while(first.Length > 1)
            {
                int[] second = new int[first.Length - 1];

                for (int i = 0; i < second.Length; i++)
                {
                        second[i] = first[i] + first[i + 1];
                }
                first = second;

            }
            
            Console.WriteLine(first[0]);
        }
    }
}
/*
2 10 3

5 0 4 1 2

*/