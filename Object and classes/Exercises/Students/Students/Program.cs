public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public float Grade { get; private set; }

    public Student(string firstName, string lastName, float grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}

public class ProgramStudents
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] studentDetails = input.Split(' ');
            string firstName = studentDetails[0];
            string lastName = studentDetails[1];
            float grade = float.Parse(studentDetails[2]);

            Student student = new Student(firstName, lastName, grade);
            students.Add(student);
        }

        students = students.OrderByDescending(s => s.Grade).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
}
