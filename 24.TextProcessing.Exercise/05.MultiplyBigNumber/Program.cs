using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0 )
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder sb = new StringBuilder();

            int carry = 0;
            int result = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result = (number[i] - '0') * multiplier + carry;

                carry = result / 10;
                sb.Append(result % 10);
            }

            if (carry != 0) sb.Append(carry);

            for (int i = 0; i < sb.Length /2; i++)
            {
                char temp = sb[i];
                sb[i] = sb[sb.Length - 1 - i];
                sb[sb.Length - 1 - i] = temp;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
