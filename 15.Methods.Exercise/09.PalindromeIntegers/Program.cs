
using System.Text;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(Reverse(input) == input);
            }
        }

        static string Reverse(string input)
        {
            var reversed = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }
    }
}
