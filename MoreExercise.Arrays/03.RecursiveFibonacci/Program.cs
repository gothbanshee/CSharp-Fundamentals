namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 50)
            {
                return;
            }
            if (num == 1 || num == 2)
            {
                Console.WriteLine("1");
                return;
            }

            int[] fibonacci = new int[num];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine(fibonacci[num - 1]);
        }
    }
}
