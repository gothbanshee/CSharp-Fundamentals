namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiddleChar(Console.ReadLine());

            static void MiddleChar(string input)
            {
                if (input.Length % 2 == 0)
                {
                    Console.Write(input[input.Length / 2 - 1]); 
                }
                Console.WriteLine(input[input.Length / 2]); 
            }
        }
    }
}
