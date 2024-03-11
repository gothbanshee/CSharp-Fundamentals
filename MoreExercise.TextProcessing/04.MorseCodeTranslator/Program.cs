using System.Text;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] code = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();

            StringBuilder sb = new StringBuilder();
            sb.Capacity = code.Length;

            foreach (string line in code)
            {
                if (line == "|") sb.Append(' ');
                else if (line == ".-") sb.Append('A');
                else if (line == "-...") sb.Append('B');
                else if (line == "-.-.") sb.Append('C');
                else if (line == "-..") sb.Append('D');
                else if (line == ".") sb.Append('E');
                else if (line == "..-.") sb.Append('F');
                else if (line == "--.") sb.Append('G');
                else if (line == "....") sb.Append('H');
                else if (line == "..") sb.Append('I');
                else if (line == ".---") sb.Append('J');
                else if (line == "-.-") sb.Append('K');
                else if (line == ".-..") sb.Append('L');
                else if (line == "--") sb.Append('M');
                else if (line == "-.") sb.Append('N');
                else if (line == "---") sb.Append('O');
                else if (line == ".--.") sb.Append('P');
                else if (line == "--.-") sb.Append('Q');
                else if (line == ".-.") sb.Append('R');
                else if (line == "...") sb.Append('S');
                else if (line == "-") sb.Append('T');
                else if (line == "..-") sb.Append('U');
                else if (line == "...-") sb.Append('V');
                else if (line == ".--") sb.Append('W');
                else if (line == "-..-") sb.Append('X');
                else if (line == "-.--") sb.Append('Y');
                else if (line == "--..") sb.Append('Z');
            }

            Console.WriteLine(sb);
        }
    }
}
