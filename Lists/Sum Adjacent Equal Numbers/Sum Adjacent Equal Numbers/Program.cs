namespace Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1; // Reset index to start checking from the beginning again
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
