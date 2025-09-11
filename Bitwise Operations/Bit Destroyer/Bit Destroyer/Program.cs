namespace Bit_Destroyer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int p = int.Parse(Console.ReadLine()!);
            int mask = ~(1 << p); // Create a mask with 0 at position p and 1s elsewhere
            Console.WriteLine(n & mask);
        }
    }
}
