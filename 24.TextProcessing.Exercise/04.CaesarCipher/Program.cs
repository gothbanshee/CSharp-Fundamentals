using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Capacity = input.Length;

            foreach (char c in input)
            {
                sb.Append((char)(c + 3));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
