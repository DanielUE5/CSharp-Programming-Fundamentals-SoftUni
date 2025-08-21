class SmallestOf3Numbers
{
    static void Main()
    {
        Numbers();
    }

    static void Numbers()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        int smallest = FindSmallest(number1, number2, number3);

        Console.WriteLine(smallest);
    }

    static int FindSmallest(int num1, int num2, int num3)
    {
        int smallest = num1;

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest = num3;
        }

        return smallest;
    }
}
