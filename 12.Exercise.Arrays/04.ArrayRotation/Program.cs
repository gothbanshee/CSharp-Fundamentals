namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            if (n == numbers.Length)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }
            else if (n > numbers.Length)
            {
                n -= numbers.Length;
            }

            int index = numbers.Length - n - 1;

            int[] newNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                index++;
                if (index > numbers.Length - 1)
                {
                    index = 0;
                }                

                newNumbers[index] = numbers[i];
            }

            Console.WriteLine(String.Join(" ", newNumbers));
        }
    }
}
/*
51 47 32 61 21
2

32 61 21 51 47

32 21 61 1
4

32 21 61 1

2 4 15 31
5

4 15 31 2


*/