namespace Bit_at_Position_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int bitAtPosition1 = (n >> 1) & 1; // Right shift n by 1 and AND with 1 to get the bit at position 1
            Console.WriteLine(bitAtPosition1);
        }
    }
}
