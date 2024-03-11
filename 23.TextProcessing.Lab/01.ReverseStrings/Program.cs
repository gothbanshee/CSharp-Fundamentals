namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                char[] reversedArr = input.ToCharArray();
                Array.Reverse(reversedArr);
                Console.WriteLine($"{input} = {new string(reversedArr)}");
            }
        }
    }
}
