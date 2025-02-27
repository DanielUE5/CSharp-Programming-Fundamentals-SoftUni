class Convert_Meters_to_Kilometers
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());

        float kilometers = meters / 1000f;

        Console.WriteLine(kilometers.ToString("F2"));
    }
}