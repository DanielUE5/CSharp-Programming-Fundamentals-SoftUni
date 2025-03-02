class CommonElements
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split(' ');
        string[] secondArray = Console.ReadLine().Split(' ');

        var commonElements = secondArray.Intersect(firstArray);

        Console.WriteLine(string.Join(" ", commonElements));
    }
}
