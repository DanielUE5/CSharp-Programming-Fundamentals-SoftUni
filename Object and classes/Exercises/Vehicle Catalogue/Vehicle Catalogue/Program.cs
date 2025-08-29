public class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public Vehicle(string type, string model, string color, int horsepower)
    {
        Type = type;
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }
}

public class ProgramVehicle
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(' ');
            string type = parts[0];
            string model = parts[1];
            string color = parts[2];
            int horsepower = int.Parse(parts[3]);

            if (vehicles.Any(v => v.Model == model))
            {
                continue; 
            }

            Vehicle vehicle = new Vehicle(type, model, color, horsepower);
            vehicles.Add(vehicle);
        }

        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == input);
            if (vehicle != null)
            {
                Console.WriteLine($"Type: {vehicle.Type[0].ToString().ToUpper() + vehicle.Type.Substring(1)}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }
        }

        var carVehicles = vehicles.Where(v => v.Type == "car").ToList();
        var truckVehicles = vehicles.Where(v => v.Type == "truck").ToList();

        double avgCarHorsepower = carVehicles.Any() ? carVehicles.Average(v => v.Horsepower) : 0;
        double avgTruckHorsepower = truckVehicles.Any() ? truckVehicles.Average(v => v.Horsepower) : 0;

        Console.WriteLine($"Cars have average horsepower of: {avgCarHorsepower:F2}.");
        Console.WriteLine($"Trucks have average horsepower of: {avgTruckHorsepower:F2}.");
    }
}