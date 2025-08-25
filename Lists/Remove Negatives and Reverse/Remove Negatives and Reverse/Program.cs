namespace Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            integers.RemoveAll(integers => integers < 0);
            integers.Reverse();

            if (integers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", integers));
            }
        }
    }
}
