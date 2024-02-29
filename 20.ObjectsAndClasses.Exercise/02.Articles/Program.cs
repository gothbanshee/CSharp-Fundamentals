using System.Data;
using System.Reflection;

namespace _02.Articles
{
    internal class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }


        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(", ")
                                    .ToArray();
            Article article = new Article(input[0], input[1], input[2]);

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine()
                               .Split(": ")
                               .ToArray();

                switch (input[0])
                {
                    case "Edit":
                        article.Edit(input[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(input[1]);
                        break;
                    case "Rename":
                        article.Rename(input[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
