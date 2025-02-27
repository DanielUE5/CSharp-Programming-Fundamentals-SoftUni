class Pounds_to_Dollars
{
    static void Main()
    {
        double pounds = double.Parse(Console.ReadLine());
        double dollars = pounds * 1.31;

        Console.WriteLine(dollars.ToString("F3"));
    }
}