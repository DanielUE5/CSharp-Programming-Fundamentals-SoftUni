namespace List_of_Products
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine()!);
            List<string> products = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                string product = Console.ReadLine()!;
                products.Add(product);
            }

            products.Sort(); // Sorting the list in alphabetical order

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
