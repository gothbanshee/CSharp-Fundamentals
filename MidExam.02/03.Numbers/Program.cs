namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(input);

            bool allEqual = true;
            for (int i = 0; i < input.Length; i++)
            {
                if(i+1 > input.Length - 1)
                {
                    break;
                }

                if (input[i] != input[i + 1])
                {
                    allEqual = false;
                }
            }
            if (allEqual)
            {
                Console.WriteLine("No");
                return;
            }

            if (input.Length == 1)
            {
                Console.WriteLine("No");
                return;
            }

            int[] output = new int[5];
            //for (int i = 0; i < output.Length; i++)
            //{
            //    output[i] = null;
            //}

            double average = 0;
            foreach (int i in input)
            {
                average += i;
            }
            average /= input.Length;

            int avCount = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (input.Length - i - 1 < 0)
                {
                    return;
                }

                if (input[input.Length - i - 1] > average)
                {
                    output[i] = input[input.Length - i - 1];
                    Console.Write($"{output[i]} ");
                    avCount++;
                }
            }
            if (avCount == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
/*


*/