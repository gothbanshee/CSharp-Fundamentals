namespace _05.LIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initial = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (initial.Length == 1)
            {
                Console.WriteLine(initial[0]);
                return;
            }

            int[] length = new int[initial.Length];
            int[] prev = new int[initial.Length];

            for (int i = 0; i < initial.Length; i++)
            {           
                int left = i - 1;
                
                if(left < 0 || left > length.Length)
                {
                    length[i] = 1;
                }

                length[i] = length[left + 1];
                
                prev[i] = left;
            }

            int[] LIS = length;
            Console.WriteLine(String.Join(" ", LIS));
        }
    }
}
