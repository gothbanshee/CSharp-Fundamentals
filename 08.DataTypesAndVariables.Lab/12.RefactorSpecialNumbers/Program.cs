namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int j = i;
                bool isSpecialNum = false;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{j} -> {isSpecialNum}");
                sum = 0;
                i = j;
            }
        }
    }
}
