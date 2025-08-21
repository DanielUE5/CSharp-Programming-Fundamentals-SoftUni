class MiddleCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        PrintMiddleCharacters(input);
    }

    static void PrintMiddleCharacters(string str)
    {
        int length = str.Length;

        if (length % 2 == 0)
        {
            int mid1 = length / 2 - 1;
            int mid2 = length / 2;
            Console.WriteLine($"{str[mid1]}{str[mid2]}");
        }
        else
        {
            int mid = length / 2;
            Console.WriteLine($"{str[mid]}");
        }
    }
}
