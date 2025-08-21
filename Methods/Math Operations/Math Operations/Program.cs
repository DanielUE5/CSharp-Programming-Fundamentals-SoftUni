namespace Math_Operations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            string op = Console.ReadLine();

            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num1, num2, op);
            Console.WriteLine(result);
        }
            public static double Calculate(int number1, int number2, string operation)
            {
                double result = 0;

                result = operation switch
                {
                    "+" => number1 + number2,
                    "-" => number1 - number2,
                    "*" => number1 * number2,
                    "/" => number1 / (double)number2,
                    "%" => number1 % number2,
                    "^" => Math.Pow(number1, number2),
                    _ => throw new InvalidOperationException("Invalid operation")
                };
                return result;
        }

    }
}

