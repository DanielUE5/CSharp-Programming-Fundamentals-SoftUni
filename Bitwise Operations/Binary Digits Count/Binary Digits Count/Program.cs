namespace Binary_Digits_Count
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);

            if (b != 1 && b != 0)
            {
                Console.WriteLine("Error");
                return;
            } else
            {
                int count = 0;
                while (n > 0) // While there are still bits to check
                {
                    if ((n & 1) == b) count++; // Check the least significant bit
                    n >>= 1; // Right shift n to check the next bit
                }
                Console.WriteLine(count);
            }
        }
    }
}
