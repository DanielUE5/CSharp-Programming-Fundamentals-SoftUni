class Print_and_Sum
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = num1; i <= num2; i++) {
            Console.Write(i + " ");
            count += i;
        }
        Console.WriteLine();
        Console.WriteLine($"Sum: {count}");
    } 
}