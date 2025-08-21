namespace Calculations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintUsage();

            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
                default:
                    Console.WriteLine("Unknown command. Please use one of the following:");
                    PrintUsage();
                    break;
            }
        }
        private static void PrintUsage()
        {
            Console.WriteLine("Usage: <command> <a> <b>");
            Console.WriteLine("Commands:");
            Console.WriteLine("  add       - Adds two numbers");
            Console.WriteLine("  subtract  - Subtracts second number from first");
            Console.WriteLine("  multiply  - Multiplies two numbers");
            Console.WriteLine("  divide    - Divides first number by second (division by zero is not allowed)");
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
    }
}

