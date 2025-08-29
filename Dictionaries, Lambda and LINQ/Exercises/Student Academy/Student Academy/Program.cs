class StudentAcademy
{
    static void Main()
    {
        Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!studentGrades.ContainsKey(name))
            {
                studentGrades[name] = new List<double>();
            }

            studentGrades[name].Add(grade);
        }

        var filteredStudents = studentGrades
            .Select(s => new
            {
                Name = s.Key,
                AverageGrade = s.Value.Average()
            })
            .Where(s => s.AverageGrade >= 4.50)
            .ToList();

        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
        }
    }
}
