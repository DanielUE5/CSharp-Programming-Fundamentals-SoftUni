namespace Math_Power
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int theBase = int.Parse(Console.ReadLine() ?? "0");
            int thePower = int.Parse(Console.ReadLine() ?? "0");

            int power = Power(theBase, thePower); // Calculate the power of the base raised to the exponent.
            Console.WriteLine(power);
        }

        // Calculates the power of a number using recursion.
        private static int Power(int baseNum, int powerNum)
            {
                if (powerNum == 0)
                {
                    return 1;
                }
                return baseNum * Power(baseNum, powerNum - 1); // Recursive call
        }
    }
}

