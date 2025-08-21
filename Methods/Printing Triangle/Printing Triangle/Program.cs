namespace Printing_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // Prints a line of numbers from start to end
            static void PrintLine(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            // Print the upper part of the triangle
            for (int i = 1; i <= num; i++)
            {
                PrintLine(1, i);
            }

            // Print the lower part of the triangle
            for (int i = num - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
