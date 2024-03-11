namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string header = Console.ReadLine();

            string article = Console.ReadLine();
            Console.WriteLine($"<h1>\r\n    {header}\r\n</h1>");
            Console.WriteLine($"<article>\r\n    {article}\r\n</article>");

            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine($"<div>\r\n    {input}\r\n</div>");
            }
        }
    }
}
