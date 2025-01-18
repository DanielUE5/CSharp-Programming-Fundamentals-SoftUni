class Sum_of_Odd_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int sum = 0;

        for (int i = 1; count < n; i++)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
                count++;
                sum += i;
            }
        }
        Console.WriteLine("Sum: " + sum);
    }
}
