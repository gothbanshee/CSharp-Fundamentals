namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split('|')
                                    .ToArray();

            List<string> output = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] trimmedInput = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < trimmedInput.Length; j++)
                {
                    output = output.Append(trimmedInput[j]).ToList();
                }
            }
            Console.WriteLine(String.Join(" ", output));
        }
    }
}
