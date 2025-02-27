class CharsToString
{
    static void Main()
    {
        char input1 = char.Parse(Console.ReadLine());
        char input2 = char.Parse(Console.ReadLine());
        char input3 = char.Parse(Console.ReadLine());

        string result = input1.ToString() + input2.ToString() + input3.ToString();

        Console.WriteLine(result);
    }
}
