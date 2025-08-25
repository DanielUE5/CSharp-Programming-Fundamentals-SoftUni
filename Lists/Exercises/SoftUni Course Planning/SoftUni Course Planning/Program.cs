class CoursePlanning
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine().Split(", ").ToList();
        string command;

        while ((command = Console.ReadLine()) != "course start")
        {
            string[] commandParts = command.Split(":");
            string action = commandParts[0];

            if (action == "Add")
            {
                string lessonTitle = commandParts[1];
                if (!schedule.Contains(lessonTitle))
                {
                    schedule.Add(lessonTitle);
                }
            }
            else if (action == "Insert")
            {
                string lessonTitle = commandParts[1];
                int index = int.Parse(commandParts[2]);
                if (!schedule.Contains(lessonTitle))
                {
                    schedule.Insert(index, lessonTitle);
                }
            }
            else if (action == "Remove")
            {
                string lessonTitle = commandParts[1];
                if (schedule.Contains(lessonTitle))
                {
                    schedule.Remove(lessonTitle);
                }
                string exerciseTitle = $"{lessonTitle}-Exercise";
                if (schedule.Contains(exerciseTitle))
                {
                    schedule.Remove(exerciseTitle);
                }
            }
            else if (action == "Swap")
            {
                string lesson1 = commandParts[1];
                string lesson2 = commandParts[2];
                if (schedule.Contains(lesson1) && schedule.Contains(lesson2))
                {
                    int index1 = schedule.IndexOf(lesson1);
                    int index2 = schedule.IndexOf(lesson2);
                    schedule[index1] = lesson2;
                    schedule[index2] = lesson1;

                    string exercise1 = $"{lesson1}-Exercise";
                    string exercise2 = $"{lesson2}-Exercise";
                    if (schedule.Contains(exercise1) && schedule.Contains(exercise2))
                    {
                        int indexEx1 = schedule.IndexOf(exercise1);
                        int indexEx2 = schedule.IndexOf(exercise2);
                        schedule[indexEx1] = exercise2;
                        schedule[indexEx2] = exercise1;
                    }
                    else if (schedule.Contains(exercise1))
                    {
                        schedule.Remove(exercise1);
                        schedule.Insert(index2 + 1, exercise1);
                    }
                    else if (schedule.Contains(exercise2))
                    {
                        schedule.Remove(exercise2);
                        schedule.Insert(index1 + 1, exercise2);
                    }
                }
            }
            else if (action == "Exercise")
            {
                string lessonTitle = commandParts[1];
                string exerciseTitle = $"{lessonTitle}-Exercise";
                if (schedule.Contains(lessonTitle))
                {
                    int lessonIndex = schedule.IndexOf(lessonTitle);
                    if (!schedule.Contains(exerciseTitle))
                    {
                        schedule.Insert(lessonIndex + 1, exerciseTitle);
                    }
                }
                else
                {
                    schedule.Add(lessonTitle);
                    schedule.Add(exerciseTitle);
                }
            }
        }

        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }
    }
}
