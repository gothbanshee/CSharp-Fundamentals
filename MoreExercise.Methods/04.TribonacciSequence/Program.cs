namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("1");
                    return;
                case 2:
                    Console.WriteLine("1 1");
                    return;
                case 3:
                    Console.WriteLine("1 1 2");
                    return;
            }

            int[] tribonacci = new int[num];
            tribonacci[0] = 1;
            tribonacci[1] = 1;
            tribonacci[2] = 2;

            for (int i = 3; i < tribonacci.Length; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }

            Console.WriteLine(String.Join(" ", tribonacci));
        }
    }
}
