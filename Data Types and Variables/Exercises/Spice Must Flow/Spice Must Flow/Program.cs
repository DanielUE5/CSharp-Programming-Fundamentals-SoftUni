class SpiceMustFlow
{
    static void Main()
    {
        int startingYield = int.Parse(Console.ReadLine());

        int totalSpice = 0;
        int daysOperated = 0;

        while (startingYield >= 100)
        {
            totalSpice += startingYield;
            totalSpice -= 26;
            daysOperated++;
            startingYield -= 10;
        }

        if (totalSpice >= 26)
        {
            totalSpice -= 26;
        }
        else
        {
            totalSpice = 0;
        }

        Console.WriteLine(daysOperated);
        Console.WriteLine(totalSpice);
    }
}
