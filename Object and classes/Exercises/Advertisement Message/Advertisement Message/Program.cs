class AdvertisementMessage
{
    static void Main()
    {
        string[] phrases = {
            "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can't live without this product."
        };

        string[] events = {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
        };

        string[] authors = {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        string[] cities = {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        int n = int.Parse(Console.ReadLine());
        Random random = new Random();

        List<Message> messages = new List<Message>();

        for (int i = 0; i < n; i++)
        {
            Message message = new Message(phrases, events, authors, cities, random);
            messages.Add(message);
        }

        foreach (var message in messages)
        {
            Console.WriteLine(message.GetFormattedMessage());
        }
    }
}

class Message
{
    public string Phrase { get; set; }
    public string Event { get; set; }
    public string Author { get; set; }
    public string City { get; set; }

    private static Random random = new Random();

    public Message(string[] phrases, string[] events, string[] authors, string[] cities, Random random)
    {
        this.Phrase = phrases[random.Next(phrases.Length)];
        this.Event = events[random.Next(events.Length)];
        this.Author = authors[random.Next(authors.Length)];
        this.City = cities[random.Next(cities.Length)];
    }

    public string GetFormattedMessage()
    {
        return $"{Phrase} {Event} {Author} – {City}.";
    }
}
