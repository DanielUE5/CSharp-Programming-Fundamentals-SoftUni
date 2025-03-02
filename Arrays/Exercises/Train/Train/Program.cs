class Train
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] wagons = new int[n];

        for (int i = 0; i < n; i++)
        {
            wagons[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(" ", wagons));

        int totalPassengers = 0;

        for (int i = 0; i < n; i++)
        {
            totalPassengers += wagons[i];
        }

        Console.WriteLine(totalPassengers);
    }
}
