class SumOfChars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            char ch = char.Parse(Console.ReadLine());
            totalSum += (int)ch;
        }

        Console.WriteLine($"The sum equals: {totalSum}");
    }
}
