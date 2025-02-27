class RoundedNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        double[] numbers = input.Split(' ').Select(double.Parse).ToArray();

        foreach (double num in numbers)
        {
            int rounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {rounded}");
        }
    }
}
