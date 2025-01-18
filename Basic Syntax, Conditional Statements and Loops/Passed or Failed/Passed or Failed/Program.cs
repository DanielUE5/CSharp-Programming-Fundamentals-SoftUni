class Passed_or_Failed
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());

        if (number >= 3)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}
