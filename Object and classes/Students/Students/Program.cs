namespace Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];

                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(student);
                input = Console.ReadLine();
            }
            string city = Console.ReadLine();

            List<Students> filteredStudents = students.Where(s => s.Hometown == city).ToList();
            foreach (Students student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}
