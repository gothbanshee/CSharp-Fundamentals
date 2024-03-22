using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#{1,}(?<Product>[A-Z][A-Za-z\d]{4,}[A-Z])@#{1,}";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                StringBuilder sb = new StringBuilder();
                if (!Regex.Match(input, pattern).Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    foreach (char c in input)
                    {
                        if (char.IsDigit(c)) sb.Append(c);
                    }

                    if (sb.Length == 0) sb.Append("00");
                    
                    Console.WriteLine($"Product group: {sb.ToString()}");
                }
            }
        }
    }
}
