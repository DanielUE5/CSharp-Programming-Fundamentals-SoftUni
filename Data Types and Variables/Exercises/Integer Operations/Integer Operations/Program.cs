class IntegerOperations
{
    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());
        int input4 = int.Parse(Console.ReadLine());

        int operation1 = input1 + input2;
        int operation2 = operation1 / input3;
        int operation3 = operation2 * input4;

        Console.WriteLine(operation3);
    }
}