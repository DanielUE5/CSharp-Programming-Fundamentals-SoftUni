namespace P_th_Bit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int p = int.Parse(Console.ReadLine()!);
            int bitAtPositionP = (n >> p) & 1;
            Console.WriteLine(bitAtPositionP);
            // Example: For n = 5 (binary 101) and p = 0, output will be 1 (the 0th bit is 1)
        }
    }
}
