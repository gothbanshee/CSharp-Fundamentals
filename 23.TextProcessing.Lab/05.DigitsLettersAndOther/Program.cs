using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            digits.Capacity = input.Length;

            StringBuilder letters = new StringBuilder();
            letters.Capacity = input.Length;

            StringBuilder symbols = new StringBuilder();
            symbols.Capacity = input.Length;

            foreach (char l in input)
            {
                if (char.IsDigit(l)) digits.Append(l);
                else if (char.IsLetter(l)) letters.Append(l);
                else symbols.Append(l);
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
