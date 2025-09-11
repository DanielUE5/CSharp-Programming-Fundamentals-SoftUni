namespace Odd_Times
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Aggregate(0, (acc, x) => acc ^ x); // XOR operation to find the odd occurring number

            Console.WriteLine(sum);
        }
    }
}
