namespace Tri_bit_Switch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int p = int.Parse(Console.ReadLine()!);

            int mask = 7 << p; // 7 is 111 in binary, shifting it to position p
            int result = n ^ mask; // Toggle the bits using XOR

            Console.WriteLine(result);
        }
    }
}
