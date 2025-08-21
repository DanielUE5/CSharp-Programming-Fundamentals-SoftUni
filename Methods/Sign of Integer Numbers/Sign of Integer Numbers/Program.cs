namespace Sign_of_Integer_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignOfInteger(number);

            private static void SignOfInteger(int number)
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is zero.");
                }
            }
        }
    }
}
