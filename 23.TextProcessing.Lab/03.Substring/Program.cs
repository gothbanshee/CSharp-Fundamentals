using System.Text;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string toCheck = Console.ReadLine();

            while (toCheck.Contains(toRemove)) toCheck = toCheck.Replace(toRemove, "");

            Console.WriteLine(toCheck);
        }
    }
}
