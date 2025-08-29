public class Article2
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article2(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

public class ProgramArticles
{
    public static void Main(string[] args)
    {
        int numberOfArticles = int.Parse(Console.ReadLine());

        List<Article2> articles = new List<Article2>();

        for (int i = 0; i < numberOfArticles; i++)
        {
            string input = Console.ReadLine();
            string[] articleDetails = input.Split(", ");
            string title = articleDetails[0];
            string content = articleDetails[1];
            string author = articleDetails[2];

            Article2 article = new Article2(title, content, author);
            articles.Add(article);
        }

        foreach (var article in articles)
        {
            Console.WriteLine(article.ToString());
        }
    }
}