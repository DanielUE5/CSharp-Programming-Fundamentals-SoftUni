namespace Vehicle_Catalogue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> input = new List<string>();
            Catalogue catalogue = new Catalogue();

            string command = Console.ReadLine();

            while (command != "end")
            {
                input = command.Split('/').ToList();
                if (input[0] == "Car")
                {
                    Car car = new Car(input[1], input[2], int.Parse(input[3])); // Create a new Car object
                    catalogue.Cars.Add(car); // Add the car to the catalogue
                }
                else if (input[0] == "Truck")
                {
                    Truck truck = new Truck(input[1], input[2], int.Parse(input[3])); // Create a new Truck object
                    catalogue.Trucks.Add(truck); // Add the truck to the catalogue
                }
                command = Console.ReadLine(); // read next command
            }

            if (catalogue.Cars.Count > 0) 
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.Cars.OrderBy(c => c.Brand)) // LINQ to order cars by brand in ascending order
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                if (catalogue.Trucks.Count > 0) 
                {
                    Console.WriteLine("Trucks:");
                    foreach (var truck in catalogue.Trucks.OrderBy(t => t.Brand)) // LINQ to order trucks by brand in ascending order
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
                }
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
            public Truck(string brand, string model, int weight) // Constructor
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
            public Car(string brand, string model, int horsePower) // Constructor
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        class Catalogue // Catalogue class to hold lists of cars and trucks
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
            public Catalogue()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
    }
}
