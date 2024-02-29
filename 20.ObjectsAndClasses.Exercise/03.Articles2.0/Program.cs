using System.Data;

namespace _03.Articles2._0
{
    internal class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; }
        public string Content { get; }
        public string Author { get; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                        .Split(", ")
                                        .ToArray();

                Article article = new Article(command[0], command[1], command[2]);
                
                articles.Add(article);
            }

            articles.ForEach(article => Console.WriteLine(article));
        }
    }
}
