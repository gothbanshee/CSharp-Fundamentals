namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int opening = 0;
            int closing = 0;
            int indexOp = int.MinValue;
            int i = 0;

            if (n > 0)
            {
                for (; i < n; i++)
                {
                    string input = Console.ReadLine();

                    if (input == "(")
                    {
                        if (indexOp == i - 1)
                        {
                            break;
                        }

                        opening++;
                        indexOp = i;
                    }
                    else if (input == ")")
                    {
                        closing++;
                    }
                }

                if (indexOp == i - 1)
                {
                    Console.WriteLine("UNBALANCED");
                }
                else if (opening == 0 && closing == 0)
                {
                    Console.WriteLine("UNBALANCED");
                }
                else if (opening == closing)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}