using System.Dynamic;

namespace Students_2._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string? input = Console.ReadLine();
            while (input != "end") 
            {
                if (input == null) // Guard against null input
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < 4) // Guard against insufficient tokens
                {
                    input = Console.ReadLine();
                    continue;
                }
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];

                if (IsStudentExisting(students, firstName, lastName)) // Update existing student
                {
                    Students existingStudent = students.First(s => s.FirstName == firstName && s.LastName == lastName);
                    existingStudent.Age = age;
                    existingStudent.Hometown = hometown;
                    input = Console.ReadLine();
                    continue;
                }

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
            string? city = Console.ReadLine();
            if (city != null)
            {
                List<Students> filteredStudents = students.Where(s => s.Hometown == city).ToList(); // Filter students by hometown
                foreach (Students student in filteredStudents)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Students> students, string firstName, string lastName) // Check if a student already exists
        {
            foreach (Students student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        public class Students
        {
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
            public int Age { get; set; }
            public required string Hometown { get; set; }
        }
    }
}
