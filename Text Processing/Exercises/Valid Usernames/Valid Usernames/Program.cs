using System.Text.RegularExpressions;
class ValidUsernames
{
    static void Main()
    {
        string input = Console.ReadLine();

        var usernames = input.Split(new[] { ", " }, StringSplitOptions.None);

        string pattern = @"^[a-zA-Z0-9_-]{3,16}$";
        Regex regex = new Regex(pattern);

        var validUsernames = usernames.Where(username => regex.IsMatch(username));
        foreach (var username in validUsernames)
        {
            Console.WriteLine(username);
        }
    }
}
