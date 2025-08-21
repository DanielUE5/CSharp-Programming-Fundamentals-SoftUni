class Add_and_Subtract
{
static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = Sum(a, b);

        int result = Subtract(sum, c);

        Console.WriteLine(result);
    }

static int Sum(int a, int b)
    {
        return a + b;
    }

static int Subtract(int sum, int c)
    {
        return sum - c;
    }
}
