namespace Orders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            ProcessOrder(product, quantity);

            static void ProcessOrder(string product, int quantity)
            {
                if (product == "coffee")
                {
                    Console.WriteLine((quantity * 1.50).ToString("F2"));
                }
                else if (product == "water")
                {
                    Console.WriteLine((quantity * 1).ToString("F2"));
                }
                else if (product == "coke")
                {
                    Console.WriteLine((quantity * 1.40).ToString("F2"));
                }
                else if (product == "snacks")
                {
                    Console.WriteLine((quantity * 2).ToString("F2"));
                }
            }
        }
    }
}
