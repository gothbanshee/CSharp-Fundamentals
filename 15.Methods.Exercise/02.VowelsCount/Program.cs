
namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelsCount(Console.ReadLine()));
        }

        private static int VowelsCount(string input)
        {
            int count = 0;

            foreach (char letter in input)
            {
                if ("aoueiAOUEI".Contains(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
