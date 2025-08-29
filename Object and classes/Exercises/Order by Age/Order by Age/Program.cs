public class OrderByAge
{
    public static void Main(string[] args)
    {
        List<(string Name, string ID, int Age)> people = new List<(string Name, string ID, int Age)>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(' ');
            string name = parts[0];
            string id = parts[1];
            int age = int.Parse(parts[2]);

            people.Add((name, id, age));
        }

        var sortedPeople = people
            .OrderBy(p => p.Age)
            .ToList();

        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}
