using System.Text;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();

                if (command[0] == "merge")
                {
                    int start = int.Parse(command[1]);
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int end = int.Parse(command[2]);
                    if (end < 0)
                    {
                        end = 0;
                    }
                    if (end >= elements.Count - 1)
                    {
                        end = elements.Count - 1;
                    }

                    for (int i = start; i < end; i++)
                    {
                        elements[start] += elements[start + 1];
                        elements.Remove(elements[start + 1]);
                    }
                }
                else
                {
                    if (int.Parse(command[2]) == 0 || int.Parse(command[2]) == 1 || elements[int.Parse(command[1])].Length == 1)
                    {
                        continue;
                    }

                    int letters = elements[int.Parse(command[1])].Count() / int.Parse(command[2]);

                    if (elements[int.Parse(command[1])].Count() % int.Parse(command[2]) == 0)
                    {
                        List<string> dividedRange = new List<string>();
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            var divided = new StringBuilder(letters);

                            for (int j = 0; j < letters; j++)
                            {
                                divided.Append(elements[int.Parse(command[1])][dividedRange.Count * letters + j]);
                            }
                            dividedRange.Add(divided.ToString());
                        }
                        elements.RemoveAt(int.Parse(command[1]));
                        elements.InsertRange(int.Parse(command[1]), dividedRange);
                    }
                    else
                    {
                        List<string> dividedRange = new List<string>();
                        for (int i = 0; i < int.Parse(command[2]) - 1; i++)
                        {
                            var divided = new StringBuilder(letters);

                            for (int j = 0; j < letters; j++)
                            {
                                divided.Append(elements[int.Parse(command[1])][dividedRange.Count * letters + j]);
                            }
                            dividedRange.Add(divided.ToString());
                        }

                        var lastPart = new StringBuilder(letters);

                        for (int j = 0; j < letters + elements[int.Parse(command[1])].Count() % int.Parse(command[2]); j++)
                        {
                            lastPart.Append(elements[int.Parse(command[1])][dividedRange.Count * letters + j]);
                        }
                        dividedRange.Add(lastPart.ToString());

                        elements.RemoveAt(int.Parse(command[1]));
                        elements.InsertRange(int.Parse(command[1]), dividedRange);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}