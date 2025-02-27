class WaterOverflow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int tankCapacity = 255;
        int currentLiters = 0;

        for (int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (currentLiters + liters > tankCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                currentLiters += liters;
            }
        }
        Console.WriteLine(currentLiters);
    }
}
