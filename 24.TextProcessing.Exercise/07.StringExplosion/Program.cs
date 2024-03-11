using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int power = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    power += text[i + 1] - '0';
                    sb.Append(text[i]);
                }
                else if (power > 0) power--;
                else sb.Append(text[i]);
            }

            Console.WriteLine(sb);
        }
    }
}
