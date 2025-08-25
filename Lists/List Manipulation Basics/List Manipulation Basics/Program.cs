namespace List_Manipulation_Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList() ?? new List<int>();

            while (true)
            {
                string command = Console.ReadLine() ?? string.Empty;
                if (command == "end")
                {
                    break;
                }
                string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commandParts[0];
                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        list.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        list.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commandParts[1]);
                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                        }
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int indexToInsert = int.Parse(commandParts[2]);
                        if (indexToInsert >= 0 && indexToInsert <= list.Count)
                        {
                            list.Insert(indexToInsert, numberToInsert);
                        }
                        break;
                    default:
                        // Ignore invalid commands
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
