namespace Gauss__Trick
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {
                int sum = numbers[i] + numbers[count - 1 - i]; // Gauss' trick
                result.Add(sum);
            }

            if (count % 2 != 0)
            {
                result.Add(numbers[count / 2]); // Add the middle element if the count is odd
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
