namespace Store_Boxes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>(); // List to store Box objects
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = parts[0];
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3]);
                Item item = new Item(itemName, itemPrice); // Create Item object
                Box box = new Box(serialNumber, item, itemQuantity); // Create Box object
                boxes.Add(box); // Add Box to the list
            }
            foreach (Box box in boxes.OrderByDescending(b => b.PriceForABox)) // Sort boxes by PriceForABox in descending order
            {
                Console.WriteLine(box);
            }
            Console.ReadLine();
        }

        class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForABox { get; set; }
            public Box(string serialNumber, Item item, int itemQuantity) // Constructor
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
                PriceForABox = item.Price * itemQuantity;
            }
            public override string ToString() // Override ToString method
            {
                return $"{SerialNumber}\n-- {Item.Name} - ${Item.Price:F2}: {ItemQuantity}\n-- ${PriceForABox:F2}";
            }
        }

        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public Item(string name, decimal price) // Constructor
            {
                Name = name;
                Price = price;
            }
        }
    }
}
