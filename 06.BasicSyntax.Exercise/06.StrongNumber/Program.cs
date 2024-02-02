namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int total = 0;

            while (copy > 0)
            {
                int digit = copy % 10;
                copy /= 10;
                int sum = 1;

                for (int j = 1; j <= digit; j++)
                {
                    sum *= j;
                }
                total += sum;
            }
            if (num == total)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
