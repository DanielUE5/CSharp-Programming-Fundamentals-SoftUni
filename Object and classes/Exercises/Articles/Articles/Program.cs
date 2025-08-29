public class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
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
        string input = Console.ReadLine();
        string[] articleDetails = input.Split(", ");
        string title = articleDetails[0];
        string content = articleDetails[1];
        string author = articleDetails[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string command = Console.ReadLine();
            if (command.StartsWith("Edit: "))
            {
                string newContent = command.Substring("Edit: ".Length);
                article.Edit(newContent);
            }
            else if (command.StartsWith("ChangeAuthor: "))
            {
                string newAuthor = command.Substring("ChangeAuthor: ".Length);
                article.ChangeAuthor(newAuthor);
            }
            else if (command.StartsWith("Rename: "))
            {
                string newTitle = command.Substring("Rename: ".Length);
                article.Rename(newTitle);
            }
        }

        Console.WriteLine(article.ToString());
    }
}
