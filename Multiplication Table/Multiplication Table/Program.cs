class Multiplication_Table
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int sum;

        if (n2 > 10)
        {
            sum = n * n2;
            Console.WriteLine($"{n} X {n2} = {sum}");
        }
        else
        {
            for (int i = n2; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
